namespace Irregulator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblGameDir;
            System.Windows.Forms.Label lblSeed;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.fbdGameDir = new System.Windows.Forms.FolderBrowserDialog();
            this.cbxOther = new System.Windows.Forms.CheckBox();
            this.cbxHumans = new System.Windows.Forms.CheckBox();
            this.cbxBullets = new System.Windows.Forms.CheckBox();
            this.cbxSpells = new System.Windows.Forms.CheckBox();
            this.cbxGoods = new System.Windows.Forms.CheckBox();
            this.cbxRings = new System.Windows.Forms.CheckBox();
            this.cbxWeapons = new System.Windows.Forms.CheckBox();
            this.cbxArmor = new System.Windows.Forms.CheckBox();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.txtGameDir = new System.Windows.Forms.TextBox();
            lblGameDir = new System.Windows.Forms.Label();
            lblSeed = new System.Windows.Forms.Label();
            this.gbxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameDir
            // 
            lblGameDir.AutoSize = true;
            lblGameDir.Location = new System.Drawing.Point(12, 9);
            lblGameDir.Name = "lblGameDir";
            lblGameDir.Size = new System.Drawing.Size(80, 13);
            lblGameDir.TabIndex = 0;
            lblGameDir.Text = "Game Directory";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(261, 51);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExplore.Location = new System.Drawing.Point(342, 51);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(75, 23);
            this.btnExplore.TabIndex = 3;
            this.btnExplore.Text = "Explore";
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandomize.Location = new System.Drawing.Point(504, 51);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 4;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(423, 51);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // gbxOptions
            // 
            this.gbxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOptions.Controls.Add(this.cbxOther);
            this.gbxOptions.Controls.Add(this.cbxHumans);
            this.gbxOptions.Controls.Add(this.cbxBullets);
            this.gbxOptions.Controls.Add(this.cbxSpells);
            this.gbxOptions.Controls.Add(this.cbxGoods);
            this.gbxOptions.Controls.Add(this.cbxRings);
            this.gbxOptions.Controls.Add(this.cbxWeapons);
            this.gbxOptions.Controls.Add(this.cbxArmor);
            this.gbxOptions.Controls.Add(this.txtSeed);
            this.gbxOptions.Controls.Add(lblSeed);
            this.gbxOptions.Location = new System.Drawing.Point(12, 80);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(567, 250);
            this.gbxOptions.TabIndex = 6;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Options";
            // 
            // lblSeed
            // 
            lblSeed.AutoSize = true;
            lblSeed.Location = new System.Drawing.Point(6, 16);
            lblSeed.Name = "lblSeed";
            lblSeed.Size = new System.Drawing.Size(175, 13);
            lblSeed.TabIndex = 0;
            lblSeed.Text = "Seed (leave blank for random seed)";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Location = new System.Drawing.Point(12, 53);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(243, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // llbUpdate
            // 
            this.llbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbUpdate.Location = new System.Drawing.Point(129, 339);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(450, 13);
            this.llbUpdate.TabIndex = 38;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available!";
            this.llbUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llbUpdate.Visible = false;
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdate.Location = new System.Drawing.Point(126, 339);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(453, 13);
            this.lblUpdate.TabIndex = 37;
            this.lblUpdate.Text = "Checking for update...";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fbdGameDir
            // 
            this.fbdGameDir.Description = "Select your Dark Souls III install directory...";
            this.fbdGameDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbdGameDir.ShowNewFolderButton = false;
            // 
            // cbxOther
            // 
            this.cbxOther.AutoSize = true;
            this.cbxOther.Checked = global::Irregulator.Properties.Settings.Default.DoOther;
            this.cbxOther.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOther.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Irregulator.Properties.Settings.Default, "DoOther", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxOther.Location = new System.Drawing.Point(6, 219);
            this.cbxOther.Name = "cbxOther";
            this.cbxOther.Size = new System.Drawing.Size(52, 17);
            this.cbxOther.TabIndex = 9;
            this.cbxOther.Text = "Other";
            this.toolTip1.SetToolTip(this.cbxOther, "Randomizes various graphical effects");
            this.cbxOther.UseVisualStyleBackColor = true;
            // 
            // cbxHumans
            // 
            this.cbxHumans.AutoSize = true;
            this.cbxHumans.Checked = global::Irregulator.Properties.Settings.Default.DoHumans;
            this.cbxHumans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHumans.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Irregulator.Properties.Settings.Default, "DoHumans", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxHumans.Location = new System.Drawing.Point(6, 196);
            this.cbxHumans.Name = "cbxHumans";
            this.cbxHumans.Size = new System.Drawing.Size(65, 17);
            this.cbxHumans.TabIndex = 8;
            this.cbxHumans.Text = "Humans";
            this.toolTip1.SetToolTip(this.cbxHumans, "Randomizes character loadouts");
            this.cbxHumans.UseVisualStyleBackColor = true;
            // 
            // cbxBullets
            // 
            this.cbxBullets.AutoSize = true;
            this.cbxBullets.Checked = global::Irregulator.Properties.Settings.Default.DoBullets;
            this.cbxBullets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxBullets.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Irregulator.Properties.Settings.Default, "DoBullets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxBullets.Location = new System.Drawing.Point(6, 173);
            this.cbxBullets.Name = "cbxBullets";
            this.cbxBullets.Size = new System.Drawing.Size(57, 17);
            this.cbxBullets.TabIndex = 7;
            this.cbxBullets.Text = "Bullets";
            this.toolTip1.SetToolTip(this.cbxBullets, "Randomizes projectile behavior");
            this.cbxBullets.UseVisualStyleBackColor = true;
            // 
            // cbxSpells
            // 
            this.cbxSpells.AutoSize = true;
            this.cbxSpells.Checked = global::Irregulator.Properties.Settings.Default.DoSpells;
            this.cbxSpells.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSpells.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Irregulator.Properties.Settings.Default, "DoSpells", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxSpells.Location = new System.Drawing.Point(6, 150);
            this.cbxSpells.Name = "cbxSpells";
            this.cbxSpells.Size = new System.Drawing.Size(54, 17);
            this.cbxSpells.TabIndex = 6;
            this.cbxSpells.Text = "Spells";
            this.toolTip1.SetToolTip(this.cbxSpells, "Randomizes spell effects");
            this.cbxSpells.UseVisualStyleBackColor = true;
            // 
            // cbxGoods
            // 
            this.cbxGoods.AutoSize = true;
            this.cbxGoods.Checked = global::Irregulator.Properties.Settings.Default.DoGoods;
            this.cbxGoods.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxGoods.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Irregulator.Properties.Settings.Default, "DoGoods", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxGoods.Location = new System.Drawing.Point(6, 127);
            this.cbxGoods.Name = "cbxGoods";
            this.cbxGoods.Size = new System.Drawing.Size(57, 17);
            this.cbxGoods.TabIndex = 5;
            this.cbxGoods.Text = "Goods";
            this.toolTip1.SetToolTip(this.cbxGoods, "Randomizes usable item effects");
            this.cbxGoods.UseVisualStyleBackColor = true;
            // 
            // cbxRings
            // 
            this.cbxRings.AutoSize = true;
            this.cbxRings.Checked = global::Irregulator.Properties.Settings.Default.DoRings;
            this.cbxRings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRings.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Irregulator.Properties.Settings.Default, "DoRings", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxRings.Location = new System.Drawing.Point(6, 104);
            this.cbxRings.Name = "cbxRings";
            this.cbxRings.Size = new System.Drawing.Size(53, 17);
            this.cbxRings.TabIndex = 4;
            this.cbxRings.Text = "Rings";
            this.toolTip1.SetToolTip(this.cbxRings, "Randomizes ring effects");
            this.cbxRings.UseVisualStyleBackColor = true;
            // 
            // cbxWeapons
            // 
            this.cbxWeapons.AutoSize = true;
            this.cbxWeapons.Checked = global::Irregulator.Properties.Settings.Default.DoWeapons;
            this.cbxWeapons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxWeapons.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Irregulator.Properties.Settings.Default, "DoWeapons", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxWeapons.Location = new System.Drawing.Point(6, 81);
            this.cbxWeapons.Name = "cbxWeapons";
            this.cbxWeapons.Size = new System.Drawing.Size(72, 17);
            this.cbxWeapons.TabIndex = 3;
            this.cbxWeapons.Text = "Weapons";
            this.toolTip1.SetToolTip(this.cbxWeapons, "Randomizes weapon movesets and stats");
            this.cbxWeapons.UseVisualStyleBackColor = true;
            // 
            // cbxArmor
            // 
            this.cbxArmor.AutoSize = true;
            this.cbxArmor.Checked = global::Irregulator.Properties.Settings.Default.DoArmor;
            this.cbxArmor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxArmor.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Irregulator.Properties.Settings.Default, "DoArmor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxArmor.Location = new System.Drawing.Point(6, 58);
            this.cbxArmor.Name = "cbxArmor";
            this.cbxArmor.Size = new System.Drawing.Size(53, 17);
            this.cbxArmor.TabIndex = 2;
            this.cbxArmor.Text = "Armor";
            this.toolTip1.SetToolTip(this.cbxArmor, "Randomizes armor stats");
            this.cbxArmor.UseVisualStyleBackColor = true;
            // 
            // txtSeed
            // 
            this.txtSeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Irregulator.Properties.Settings.Default, "Seed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSeed.Location = new System.Drawing.Point(6, 32);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(555, 20);
            this.txtSeed.TabIndex = 1;
            this.txtSeed.Text = global::Irregulator.Properties.Settings.Default.Seed;
            this.toolTip1.SetToolTip(this.txtSeed, "Sharing a seed lets you and another player get the same result from randomization" +
        ".");
            // 
            // txtGameDir
            // 
            this.txtGameDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Irregulator.Properties.Settings.Default, "GameDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGameDir.Location = new System.Drawing.Point(12, 25);
            this.txtGameDir.Name = "txtGameDir";
            this.txtGameDir.Size = new System.Drawing.Size(567, 20);
            this.txtGameDir.TabIndex = 1;
            this.txtGameDir.Text = global::Irregulator.Properties.Settings.Default.GameDir;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 368);
            this.Controls.Add(this.llbUpdate);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.gbxOptions);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtGameDir);
            this.Controls.Add(lblGameDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(607, 406);
            this.Name = "FormMain";
            this.Text = "Irregulator <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbxOther;
        private System.Windows.Forms.CheckBox cbxHumans;
        private System.Windows.Forms.CheckBox cbxBullets;
        private System.Windows.Forms.CheckBox cbxSpells;
        private System.Windows.Forms.CheckBox cbxGoods;
        private System.Windows.Forms.CheckBox cbxRings;
        private System.Windows.Forms.CheckBox cbxWeapons;
        private System.Windows.Forms.CheckBox cbxArmor;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.GroupBox gbxOptions;
        private System.Windows.Forms.FolderBrowserDialog fbdGameDir;
    }
}

