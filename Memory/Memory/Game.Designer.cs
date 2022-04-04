namespace Memory
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panelForCards = new System.Windows.Forms.Panel();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.ToolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForCards
            // 
            this.panelForCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForCards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelForCards.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelForCards.Location = new System.Drawing.Point(0, 0);
            this.panelForCards.Name = "panelForCards";
            this.panelForCards.Size = new System.Drawing.Size(750, 500);
            this.panelForCards.TabIndex = 0;
            this.panelForCards.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForCards_Paint);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolBarPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ToolBarPanel.Controls.Add(this.score);
            this.ToolBarPanel.Controls.Add(this.timeLabel);
            this.ToolBarPanel.Controls.Add(this.settingsButton);
            this.ToolBarPanel.Location = new System.Drawing.Point(750, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(150, 500);
            this.ToolBarPanel.TabIndex = 1;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.White;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(100, 441);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(50, 50);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(61, 32);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(26, 13);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "time";
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(64, 166);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(35, 13);
            this.score.TabIndex = 0;
            this.score.Text = "0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.ToolBarPanel);
            this.Controls.Add(this.panelForCards);
            this.Name = "Game";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResizeEnd += new System.EventHandler(this.panelForCards_Resize);
            this.ToolBarPanel.ResumeLayout(false);
            this.ToolBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }
       

        #endregion

        private System.Windows.Forms.Panel panelForCards;
        private System.Windows.Forms.Panel ToolBarPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label score;
    }
}