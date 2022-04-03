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
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.soundBox = new System.Windows.Forms.ComboBox();
            this.presentationLabel = new System.Windows.Forms.Label();
            this.presentationTimeBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cardSizeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.languageLabel.Location = new System.Drawing.Point(28, 39);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(51, 13);
            this.languageLabel.TabIndex = 5;
            this.languageLabel.Text = "language";
            this.languageLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // animationSpeed
            // 
            this.animationSpeed.AutoSize = true;
            this.animationSpeed.Location = new System.Drawing.Point(28, 90);
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
            this.soundLabel.Location = new System.Drawing.Point(28, 154);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(36, 13);
            this.soundLabel.TabIndex = 8;
            this.soundLabel.Text = "sound";
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
            this.languageBox.Location = new System.Drawing.Point(31, 55);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(121, 21);
            this.languageBox.TabIndex = 10;
            this.languageBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // animationSpeedBox
            // 
            this.animationSpeedBox.Location = new System.Drawing.Point(31, 107);
            this.animationSpeedBox.Name = "animationSpeedBox";
            this.animationSpeedBox.Size = new System.Drawing.Size(121, 20);
            this.animationSpeedBox.TabIndex = 11;
            this.animationSpeedBox.Text = "2";
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(189, 107);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(48, 23);
            this.upButton.TabIndex = 12;
            this.upButton.Text = "↑";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(255, 107);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(40, 23);
            this.downButton.TabIndex = 13;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // soundBox
            // 
            this.soundBox.FormattingEnabled = true;
            this.soundBox.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.soundBox.Location = new System.Drawing.Point(31, 170);
            this.soundBox.Name = "soundBox";
            this.soundBox.Size = new System.Drawing.Size(121, 21);
            this.soundBox.TabIndex = 14;
            this.soundBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // presentationLabel
            // 
            this.presentationLabel.AutoSize = true;
            this.presentationLabel.Location = new System.Drawing.Point(31, 224);
            this.presentationLabel.Name = "presentationLabel";
            this.presentationLabel.Size = new System.Drawing.Size(101, 13);
            this.presentationLabel.TabIndex = 15;
            this.presentationLabel.Text = "presentation time [s]";
            this.presentationLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // presentationTimeBox
            // 
            this.presentationTimeBox.Location = new System.Drawing.Point(31, 240);
            this.presentationTimeBox.Name = "presentationTimeBox";
            this.presentationTimeBox.Size = new System.Drawing.Size(121, 20);
            this.presentationTimeBox.TabIndex = 16;
            this.presentationTimeBox.Text = "120";
            this.presentationTimeBox.TextChanged += new System.EventHandler(this.presentationTimeBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "↑";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "↓";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cardSizeLabel
            // 
            this.cardSizeLabel.AutoSize = true;
            this.cardSizeLabel.Location = new System.Drawing.Point(28, 299);
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
            this.comboBox1.Location = new System.Drawing.Point(31, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(457, 544);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cardSizeLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.presentationTimeBox);
            this.Controls.Add(this.presentationLabel);
            this.Controls.Add(this.soundBox);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
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
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.ComboBox soundBox;
        private System.Windows.Forms.Label presentationLabel;
        private System.Windows.Forms.TextBox presentationTimeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label cardSizeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}