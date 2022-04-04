namespace Memory
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.animationSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soundLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.animationSpeedBox = new System.Windows.Forms.TextBox();
            this.animationUp = new System.Windows.Forms.Button();
            this.animationDown = new System.Windows.Forms.Button();
            this.soundBox = new System.Windows.Forms.ComboBox();
            this.presentationLabel = new System.Windows.Forms.Label();
            this.presentationTimeBox = new System.Windows.Forms.TextBox();
            this.presentationUp = new System.Windows.Forms.Button();
            this.presentationDown = new System.Windows.Forms.Button();
            this.cardSizeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(31, 229);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(51, 13);
            this.languageLabel.TabIndex = 5;
            this.languageLabel.Text = "language";
            this.languageLabel.Visible = false;
            this.languageLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // animationSpeed
            // 
            this.animationSpeed.AutoSize = true;
            this.animationSpeed.Location = new System.Drawing.Point(28, 47);
            this.animationSpeed.Name = "animationSpeed";
            this.animationSpeed.Size = new System.Drawing.Size(98, 13);
            this.animationSpeed.TabIndex = 6;
            this.animationSpeed.Text = "animation speed [s]";
            this.animationSpeed.Click += new System.EventHandler(this.animationSpeed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // soundLabel
            // 
            this.soundLabel.AutoSize = true;
            this.soundLabel.Location = new System.Drawing.Point(31, 285);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(36, 13);
            this.soundLabel.TabIndex = 8;
            this.soundLabel.Text = "sound";
            this.soundLabel.Visible = false;
            this.soundLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageBox
            // 
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Items.AddRange(new object[] {
            "English",
            "Polish",
            "German"});
            this.languageBox.Location = new System.Drawing.Point(34, 245);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(121, 21);
            this.languageBox.TabIndex = 10;
            this.languageBox.Visible = false;
            this.languageBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // animationSpeedBox
            // 
            this.animationSpeedBox.Location = new System.Drawing.Point(31, 63);
            this.animationSpeedBox.Name = "animationSpeedBox";
            this.animationSpeedBox.Size = new System.Drawing.Size(121, 20);
            this.animationSpeedBox.TabIndex = 11;
            this.animationSpeedBox.Text = "2";
            // 
            // animationUp
            // 
            this.animationUp.Location = new System.Drawing.Point(189, 63);
            this.animationUp.Name = "animationUp";
            this.animationUp.Size = new System.Drawing.Size(48, 23);
            this.animationUp.TabIndex = 12;
            this.animationUp.Text = "↑";
            this.animationUp.UseVisualStyleBackColor = true;
            this.animationUp.Click += new System.EventHandler(this.animationUp_Click);
            // 
            // animationDown
            // 
            this.animationDown.Location = new System.Drawing.Point(255, 63);
            this.animationDown.Name = "animationDown";
            this.animationDown.Size = new System.Drawing.Size(40, 23);
            this.animationDown.TabIndex = 13;
            this.animationDown.Text = "↓";
            this.animationDown.UseVisualStyleBackColor = true;
            this.animationDown.Click += new System.EventHandler(this.animationDown_Click);
            // 
            // soundBox
            // 
            this.soundBox.FormattingEnabled = true;
            this.soundBox.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.soundBox.Location = new System.Drawing.Point(34, 301);
            this.soundBox.Name = "soundBox";
            this.soundBox.Size = new System.Drawing.Size(121, 21);
            this.soundBox.TabIndex = 14;
            this.soundBox.Visible = false;
            this.soundBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // presentationLabel
            // 
            this.presentationLabel.AutoSize = true;
            this.presentationLabel.Location = new System.Drawing.Point(31, 103);
            this.presentationLabel.Name = "presentationLabel";
            this.presentationLabel.Size = new System.Drawing.Size(101, 13);
            this.presentationLabel.TabIndex = 15;
            this.presentationLabel.Text = "presentation time [s]";
            this.presentationLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // presentationTimeBox
            // 
            this.presentationTimeBox.Location = new System.Drawing.Point(31, 119);
            this.presentationTimeBox.Name = "presentationTimeBox";
            this.presentationTimeBox.Size = new System.Drawing.Size(121, 20);
            this.presentationTimeBox.TabIndex = 16;
            this.presentationTimeBox.Text = "120";
            this.presentationTimeBox.TextChanged += new System.EventHandler(this.presentationTimeBox_TextChanged);
            // 
            // presentationUp
            // 
            this.presentationUp.Location = new System.Drawing.Point(189, 119);
            this.presentationUp.Name = "presentationUp";
            this.presentationUp.Size = new System.Drawing.Size(48, 23);
            this.presentationUp.TabIndex = 17;
            this.presentationUp.Text = "↑";
            this.presentationUp.UseVisualStyleBackColor = true;
            this.presentationUp.Click += new System.EventHandler(this.presentationUp_Click);
            // 
            // presentationDown
            // 
            this.presentationDown.Location = new System.Drawing.Point(255, 119);
            this.presentationDown.Name = "presentationDown";
            this.presentationDown.Size = new System.Drawing.Size(40, 23);
            this.presentationDown.TabIndex = 18;
            this.presentationDown.Text = "↓";
            this.presentationDown.UseVisualStyleBackColor = true;
            this.presentationDown.Click += new System.EventHandler(this.presentationDown_Click);
            // 
            // cardSizeLabel
            // 
            this.cardSizeLabel.AutoSize = true;
            this.cardSizeLabel.Location = new System.Drawing.Point(31, 160);
            this.cardSizeLabel.Name = "cardSizeLabel";
            this.cardSizeLabel.Size = new System.Drawing.Size(49, 13);
            this.cardSizeLabel.TabIndex = 19;
            this.cardSizeLabel.Text = "card size";
            this.cardSizeLabel.Click += new System.EventHandler(this.cardSizeLabel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "small",
            "medium",
            "large"});
            this.comboBox1.Location = new System.Drawing.Point(34, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(31, 454);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 35);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(317, 454);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(101, 35);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(457, 544);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cardSizeLabel);
            this.Controls.Add(this.presentationDown);
            this.Controls.Add(this.presentationUp);
            this.Controls.Add(this.presentationTimeBox);
            this.Controls.Add(this.presentationLabel);
            this.Controls.Add(this.soundBox);
            this.Controls.Add(this.animationDown);
            this.Controls.Add(this.animationUp);
            this.Controls.Add(this.animationSpeedBox);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.soundLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.animationSpeed);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Label animationSpeed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.TextBox animationSpeedBox;
        private System.Windows.Forms.Button animationUp;
        private System.Windows.Forms.Button animationDown;
        private System.Windows.Forms.ComboBox soundBox;
        private System.Windows.Forms.Label presentationLabel;
        private System.Windows.Forms.TextBox presentationTimeBox;
        private System.Windows.Forms.Button presentationUp;
        private System.Windows.Forms.Button presentationDown;
        private System.Windows.Forms.Label cardSizeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}