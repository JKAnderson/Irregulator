using Semver;
using SoulsFormats;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irregulator
{
    public partial class FormMain : Form
    {
        private const string UPDATE_LINK = "https://www.nexusmods.com/darksouls3/mods/298?tab=files";
        private static Properties.Settings settings = Properties.Settings.Default;

        private Progress<string> progress;

        public FormMain()
        {
            InitializeComponent();
            progress = new Progress<string>(status => txtStatus.Text = status);
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            Text = "Irregulator " + Application.ProductVersion;
            Location = settings.WindowLocation;
            if (settings.WindowSize.Width >= MinimumSize.Width && settings.WindowSize.Height >= MinimumSize.Height)
                Size = settings.WindowSize;
            if (settings.WindowMaximized)
                WindowState = FormWindowState.Maximized;

            Octokit.GitHubClient gitHubClient = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("Irregulator"));
            gitHubClient.SetRequestTimeout(new TimeSpan(0, 2, 0));
            try
            {
                Octokit.Release release = await gitHubClient.Repository.Release.GetLatest("JKAnderson", "Irregulator");
                if (SemVersion.Parse(release.TagName) > Application.ProductVersion)
                {
                    lblUpdate.Visible = false;
                    LinkLabel.Link link = new LinkLabel.Link();
                    link.LinkData = UPDATE_LINK;
                    llbUpdate.Links.Add(link);
                    llbUpdate.Visible = true;
                }
                else
                {
                    lblUpdate.Text = "App up to date";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is Octokit.ApiException || ex is ArgumentException)
            {
                lblUpdate.Text = "Update status unknown";
            }
        }

        private void llbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.WindowMaximized = WindowState == FormWindowState.Maximized;
            if (WindowState == FormWindowState.Normal)
            {
                settings.WindowLocation = Location;
                settings.WindowSize = Size;
            }
            else
            {
                settings.WindowLocation = RestoreBounds.Location;
                settings.WindowSize = RestoreBounds.Size;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fbdGameDir.SelectedPath = txtGameDir.Text;
            if (fbdGameDir.ShowDialog() == DialogResult.OK)
            {
                string dir = fbdGameDir.SelectedPath;
                if (Directory.Exists(dir + "\\Game") && !File.Exists(dir + "\\Data0.bdt"))
                    dir += "\\Game";
                txtGameDir.Text = dir;
            }
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            string dir = txtGameDir.Text;
            if (Directory.Exists(dir))
                Process.Start(dir);
            else
                ShowError($"Directory not found:\n{dir}");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string regPath = Path.Combine(txtGameDir.Text, "Data0.bdt");
            if (!File.Exists(regPath + ".bak"))
            {
                txtStatus.Text = "Restoration aborted.";
                ShowError($"No backup found:\n{regPath}.bak");
                return;
            }

            try
            {
                File.Delete(regPath);
                File.Copy(regPath + ".bak", regPath);
            }
            catch (Exception ex)
            {
                txtStatus.Text = "Restoration aborted.";
                ShowError($"Failed to restore regulation file:\n{regPath}\n\n{ex}");
                return;
            }

            txtStatus.Text = "Backup restored!";
            SystemSounds.Asterisk.Play();
        }

        private async void btnRandomize_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            await Task.Run(() => Randomize(progress));
            EnableControls(true);
        }

        private void Randomize(IProgress<string> progress)
        {
            progress.Report("Loading regulation...");

            string regPath = Path.Combine(txtGameDir.Text, "Data0.bdt");
            if (!File.Exists(regPath))
            {
                progress.Report("Aborted.");
                ShowError($"Regulation file not found in game directory:\n{regPath}\nPlease make sure the path is correct.");
                return;
            }

            try
            {
                if (!File.Exists(regPath + ".bak"))
                    File.Copy(regPath, regPath + ".bak");
            }
            catch (Exception ex)
            {
                progress.Report("Aborted.");
                ShowError($"Failed to back up regulation file:\n{regPath}\n\n{ex}");
                return;
            }

            BND4 regulation;
            var paramDict = new Dictionary<string, PARAM64>();
            try
            {
                regulation = Util.DecryptDS3Regulation(regPath);
                foreach (BND4.File f in regulation.Files)
                {
                    if (f.Name.EndsWith(".param"))
                    {
                        PARAM64 param = PARAM64.Read(f.Bytes);
                        PARAM64.Layout layout = PARAM64.Layout.ReadXMLFile($"Layouts\\{param.ID}.xml");
                        param.SetLayout(layout);
                        paramDict[Path.GetFileNameWithoutExtension(f.Name)] = param;
                    }
                }
            }
            catch (Exception ex)
            {
                progress.Report("Aborted.");
                ShowError($"Failed to load regulation file:\n{regPath}\n\n{ex}");
                return;
            }

            progress.Report("Randomizing...");

            try
            {
                Irregulator irreg = new Irregulator(txtSeed.Text);
                irreg.Randomize(paramDict,
                    cbxArmor.Checked, cbxWeapons.Checked, cbxRings.Checked, cbxGoods.Checked,
                    cbxSpells.Checked, cbxBullets.Checked, cbxBulletsPlus.Checked, cbxHumans.Checked, cbxOther.Checked);
            }
            catch (Exception ex)
            {
                progress.Report("Aborted.");
                ShowError($"Failed to randomize regulation file:\n{regPath}\n\n{ex}");
                return;
            }

            progress.Report("Saving regulation...");

            try
            {
                foreach (BND4.File f in regulation.Files)
                {
                    if (paramDict.ContainsKey(Path.GetFileNameWithoutExtension(f.Name)))
                        f.Bytes = paramDict[Path.GetFileNameWithoutExtension(f.Name)].Write();
                }
                Util.EncryptDS3Regulation(regPath, regulation);
            }
            catch (Exception ex)
            {
                progress.Report("Aborted.");
                ShowError($"Failed to save regulation file:\n{regPath}\n\n{ex}");
                return;
            }

            progress.Report("Finished!");
            SystemSounds.Asterisk.Play();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EnableControls(bool enable)
        {
            txtGameDir.Enabled = enable;
            btnBrowse.Enabled = enable;
            btnExplore.Enabled = enable;
            btnRestore.Enabled = enable;
            btnRandomize.Enabled = enable;
            gbxOptions.Enabled = enable;
        }
    }
}
