namespace WindowsFormsApplication1
{
    partial class frmGame
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
            this.rtbPlayerTextBlock = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnRunCode = new System.Windows.Forms.Button();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.lblRoundText = new System.Windows.Forms.Label();
            this.lblTimeText = new System.Windows.Forms.Label();
            this.rtbErrorBlock = new System.Windows.Forms.RichTextBox();
            this.btnSkipRound = new System.Windows.Forms.Button();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblRoundCount = new System.Windows.Forms.Label();
            this.lblTimeTicker = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserDifficulty = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartRound = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbPlayerTextBlock
            // 
            this.rtbPlayerTextBlock.AcceptsTab = true;
            this.rtbPlayerTextBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.rtbPlayerTextBlock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPlayerTextBlock.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPlayerTextBlock.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbPlayerTextBlock.Location = new System.Drawing.Point(194, 46);
            this.rtbPlayerTextBlock.Name = "rtbPlayerTextBlock";
            this.rtbPlayerTextBlock.Size = new System.Drawing.Size(559, 322);
            this.rtbPlayerTextBlock.TabIndex = 1;
            this.rtbPlayerTextBlock.Text = "";
            this.rtbPlayerTextBlock.WordWrap = false;
            this.rtbPlayerTextBlock.TextChanged += new System.EventHandler(this.rtbPlayerTextBlock_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 219);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(78, 13);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Chris Etheridge";
            // 
            // btnRunCode
            // 
            this.btnRunCode.ForeColor = System.Drawing.Color.Black;
            this.btnRunCode.Location = new System.Drawing.Point(648, 507);
            this.btnRunCode.Name = "btnRunCode";
            this.btnRunCode.Size = new System.Drawing.Size(105, 23);
            this.btnRunCode.TabIndex = 8;
            this.btnRunCode.Text = "Run Code";
            this.btnRunCode.UseVisualStyleBackColor = true;
            this.btnRunCode.Click += new System.EventHandler(this.btnRunCode_Click);
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.Location = new System.Drawing.Point(12, 269);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(35, 13);
            this.lblScoreText.TabIndex = 9;
            this.lblScoreText.Text = "Score";
            // 
            // lblRoundText
            // 
            this.lblRoundText.AutoSize = true;
            this.lblRoundText.Location = new System.Drawing.Point(12, 285);
            this.lblRoundText.Name = "lblRoundText";
            this.lblRoundText.Size = new System.Drawing.Size(39, 13);
            this.lblRoundText.TabIndex = 10;
            this.lblRoundText.Text = "Round";
            // 
            // lblTimeText
            // 
            this.lblTimeText.AutoSize = true;
            this.lblTimeText.Location = new System.Drawing.Point(12, 303);
            this.lblTimeText.Name = "lblTimeText";
            this.lblTimeText.Size = new System.Drawing.Size(30, 13);
            this.lblTimeText.TabIndex = 11;
            this.lblTimeText.Text = "Time";
            // 
            // rtbErrorBlock
            // 
            this.rtbErrorBlock.BackColor = System.Drawing.SystemColors.Window;
            this.rtbErrorBlock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbErrorBlock.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbErrorBlock.Location = new System.Drawing.Point(194, 374);
            this.rtbErrorBlock.Name = "rtbErrorBlock";
            this.rtbErrorBlock.ReadOnly = true;
            this.rtbErrorBlock.Size = new System.Drawing.Size(559, 127);
            this.rtbErrorBlock.TabIndex = 12;
            this.rtbErrorBlock.Text = "";
            // 
            // btnSkipRound
            // 
            this.btnSkipRound.ForeColor = System.Drawing.Color.Black;
            this.btnSkipRound.Location = new System.Drawing.Point(526, 507);
            this.btnSkipRound.Name = "btnSkipRound";
            this.btnSkipRound.Size = new System.Drawing.Size(116, 23);
            this.btnSkipRound.TabIndex = 13;
            this.btnSkipRound.Text = "Skip Round";
            this.btnSkipRound.UseVisualStyleBackColor = true;
            this.btnSkipRound.Click += new System.EventHandler(this.btnSkipRound_Click);
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Location = new System.Drawing.Point(132, 269);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(19, 13);
            this.lblScoreCount.TabIndex = 14;
            this.lblScoreCount.Text = "45";
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRoundCount.Location = new System.Drawing.Point(132, 285);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(13, 13);
            this.lblRoundCount.TabIndex = 15;
            this.lblRoundCount.Text = "0";
            this.lblRoundCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeTicker
            // 
            this.lblTimeTicker.AutoSize = true;
            this.lblTimeTicker.Location = new System.Drawing.Point(132, 303);
            this.lblTimeTicker.Name = "lblTimeTicker";
            this.lblTimeTicker.Size = new System.Drawing.Size(39, 13);
            this.lblTimeTicker.TabIndex = 16;
            this.lblTimeTicker.Text = "60 sec";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.card1_bg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "CodeDex";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Difficulty";
            // 
            // lblUserDifficulty
            // 
            this.lblUserDifficulty.AutoSize = true;
            this.lblUserDifficulty.Location = new System.Drawing.Point(132, 320);
            this.lblUserDifficulty.Name = "lblUserDifficulty";
            this.lblUserDifficulty.Size = new System.Drawing.Size(34, 13);
            this.lblUserDifficulty.TabIndex = 19;
            this.lblUserDifficulty.Text = "         ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Debug";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnStartRound
            // 
            this.btnStartRound.Location = new System.Drawing.Point(194, 508);
            this.btnStartRound.Name = "btnStartRound";
            this.btnStartRound.Size = new System.Drawing.Size(75, 23);
            this.btnStartRound.TabIndex = 21;
            this.btnStartRound.Text = "Start Round";
            this.btnStartRound.UseVisualStyleBackColor = true;
            this.btnStartRound.Click += new System.EventHandler(this.btnStartRound_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "You are playing Code Wars";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStartRound);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblUserDifficulty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTimeTicker);
            this.Controls.Add(this.lblRoundCount);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.btnSkipRound);
            this.Controls.Add(this.rtbErrorBlock);
            this.Controls.Add(this.lblTimeText);
            this.Controls.Add(this.lblRoundText);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.btnRunCode);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtbPlayerTextBlock);
            this.Controls.Add(this.label1);
            this.Name = "frmGame";
            this.Text = "Code War";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPlayerTextBlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnRunCode;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Label lblRoundText;
        private System.Windows.Forms.Label lblTimeText;
        private System.Windows.Forms.RichTextBox rtbErrorBlock;
        private System.Windows.Forms.Button btnSkipRound;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblRoundCount;
        private System.Windows.Forms.Label lblTimeTicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserDifficulty;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStartRound;
        private System.Windows.Forms.Label label3;
    }
}

