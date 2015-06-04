namespace WindowsFormsApplication1
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.radioEasy = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioHard = new System.Windows.Forms.RadioButton();
            this.checkUseHints = new System.Windows.Forms.CheckBox();
            this.checkAllowSkipRounds = new System.Windows.Forms.CheckBox();
            this.rtbInfoText = new System.Windows.Forms.RichTextBox();
            this.menuMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informatioBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDifficulty = new System.Windows.Forms.GroupBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxInfiniteTime = new System.Windows.Forms.CheckBox();
            this.menuMainMenu.SuspendLayout();
            this.grpDifficulty.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioEasy
            // 
            this.radioEasy.AutoSize = true;
            this.radioEasy.Checked = true;
            this.radioEasy.Location = new System.Drawing.Point(5, 29);
            this.radioEasy.Name = "radioEasy";
            this.radioEasy.Size = new System.Drawing.Size(48, 17);
            this.radioEasy.TabIndex = 2;
            this.radioEasy.TabStop = true;
            this.radioEasy.Text = "Easy";
            this.radioEasy.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Location = new System.Drawing.Point(6, 52);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(62, 17);
            this.radioMedium.TabIndex = 3;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioHard
            // 
            this.radioHard.AutoSize = true;
            this.radioHard.Location = new System.Drawing.Point(6, 77);
            this.radioHard.Name = "radioHard";
            this.radioHard.Size = new System.Drawing.Size(48, 17);
            this.radioHard.TabIndex = 4;
            this.radioHard.Text = "Hard";
            this.radioHard.UseVisualStyleBackColor = true;
            // 
            // checkUseHints
            // 
            this.checkUseHints.AutoSize = true;
            this.checkUseHints.Location = new System.Drawing.Point(6, 30);
            this.checkUseHints.Name = "checkUseHints";
            this.checkUseHints.Size = new System.Drawing.Size(78, 17);
            this.checkUseHints.TabIndex = 6;
            this.checkUseHints.Text = "Show hints";
            this.checkUseHints.UseVisualStyleBackColor = true;
            // 
            // checkAllowSkipRounds
            // 
            this.checkAllowSkipRounds.AutoSize = true;
            this.checkAllowSkipRounds.Location = new System.Drawing.Point(6, 54);
            this.checkAllowSkipRounds.Name = "checkAllowSkipRounds";
            this.checkAllowSkipRounds.Size = new System.Drawing.Size(108, 17);
            this.checkAllowSkipRounds.TabIndex = 7;
            this.checkAllowSkipRounds.Text = "Allow round skips";
            this.checkAllowSkipRounds.UseVisualStyleBackColor = true;
            this.checkAllowSkipRounds.CheckedChanged += new System.EventHandler(this.checkAllowCheats_CheckedChanged);
            // 
            // rtbInfoText
            // 
            this.rtbInfoText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtbInfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfoText.Location = new System.Drawing.Point(13, 194);
            this.rtbInfoText.Name = "rtbInfoText";
            this.rtbInfoText.Size = new System.Drawing.Size(691, 141);
            this.rtbInfoText.TabIndex = 8;
            this.rtbInfoText.Text = resources.GetString("rtbInfoText.Text");
            // 
            // menuMainMenu
            // 
            this.menuMainMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuMainMenu.Name = "menuMainMenu";
            this.menuMainMenu.Size = new System.Drawing.Size(715, 24);
            this.menuMainMenu.TabIndex = 9;
            this.menuMainMenu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informatioBoxToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // informatioBoxToolStripMenuItem
            // 
            this.informatioBoxToolStripMenuItem.Name = "informatioBoxToolStripMenuItem";
            this.informatioBoxToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.informatioBoxToolStripMenuItem.Text = "Information Box";
            this.informatioBoxToolStripMenuItem.Click += new System.EventHandler(this.informatioBoxToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // grpDifficulty
            // 
            this.grpDifficulty.Controls.Add(this.radioEasy);
            this.grpDifficulty.Controls.Add(this.radioMedium);
            this.grpDifficulty.Controls.Add(this.radioHard);
            this.grpDifficulty.Location = new System.Drawing.Point(13, 350);
            this.grpDifficulty.Name = "grpDifficulty";
            this.grpDifficulty.Size = new System.Drawing.Size(143, 117);
            this.grpDifficulty.TabIndex = 10;
            this.grpDifficulty.TabStop = false;
            this.grpDifficulty.Text = "Difficulty";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.cbxInfiniteTime);
            this.grpOptions.Controls.Add(this.checkUseHints);
            this.grpOptions.Controls.Add(this.checkAllowSkipRounds);
            this.grpOptions.Location = new System.Drawing.Point(162, 350);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(143, 117);
            this.grpOptions.TabIndex = 11;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(628, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Quit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(6, 16);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(131, 20);
            this.txtUserName.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(313, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 42);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(691, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Code Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cbxInfiniteTime
            // 
            this.cbxInfiniteTime.AutoSize = true;
            this.cbxInfiniteTime.Location = new System.Drawing.Point(6, 77);
            this.cbxInfiniteTime.Name = "cbxInfiniteTime";
            this.cbxInfiniteTime.Size = new System.Drawing.Size(83, 17);
            this.cbxInfiniteTime.TabIndex = 8;
            this.cbxInfiniteTime.Text = "Infinite Time";
            this.cbxInfiniteTime.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 479);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpDifficulty);
            this.Controls.Add(this.rtbInfoText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuMainMenu);
            this.MainMenuStrip = this.menuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "Code Wars";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuMainMenu.ResumeLayout(false);
            this.menuMainMenu.PerformLayout();
            this.grpDifficulty.ResumeLayout(false);
            this.grpDifficulty.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioEasy;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioHard;
        private System.Windows.Forms.CheckBox checkUseHints;
        private System.Windows.Forms.CheckBox checkAllowSkipRounds;
        private System.Windows.Forms.RichTextBox rtbInfoText;
        private System.Windows.Forms.MenuStrip menuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informatioBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpDifficulty;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbxInfiniteTime;
    }
}