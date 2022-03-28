namespace Memory
{
    partial class SelectLevel
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
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.BackColor = Style.getButtonColor();
            this.easyButton.Font = Style.getButtonFont();
            this.easyButton.Location = new System.Drawing.Point(55, 189);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(344, 91);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "easy (48)";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButtonClick);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = Style.getButtonColor();
            this.mediumButton.Font = Style.getButtonFont();
            this.mediumButton.Location = new System.Drawing.Point(55, 302);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(344, 91);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.Text = "medium (80)";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButtonClick);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = Style.getButtonColor();
            this.hardButton.Font =  Style.getButtonFont();
            this.hardButton.Location = new System.Drawing.Point(55, 412);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(344, 91);
            this.hardButton.TabIndex = 2;
            this.hardButton.Text = "hard (120)";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButtonClick);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(99, 76);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(275, 49);
            this.title.TabIndex = 3;
            this.title.Text = "memory game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Style.getBackgroundColor();
            this.ClientSize = new System.Drawing.Size(457, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
    }
}

