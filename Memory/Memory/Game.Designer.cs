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
            this.panelForCards = new System.Windows.Forms.Panel();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelForCards
            // 
            this.panelForCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForCards.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelForCards.Location = new System.Drawing.Point(0, 0);
            this.panelForCards.Name = "panelForCards";
            this.panelForCards.Size = new System.Drawing.Size(750, 500);
            this.panelForCards.TabIndex = 0;
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolBarPanel.AutoSize = true;
            this.ToolBarPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ToolBarPanel.Location = new System.Drawing.Point(750, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(150, 500);
            this.ToolBarPanel.TabIndex = 1;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       

        #endregion

        private System.Windows.Forms.Panel panelForCards;
        private System.Windows.Forms.Panel ToolBarPanel;
        
            
        }
}