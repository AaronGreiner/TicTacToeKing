namespace TicTacToe.Components.Controls
{
    partial class SingleplayerDifficultyControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHard = new TicTacToe.Components.Buttons.ButtonMedium();
            this.buttonMedium = new TicTacToe.Components.Buttons.ButtonMedium();
            this.buttonEasy = new TicTacToe.Components.Buttons.ButtonMedium();
            this.SuspendLayout();
            // 
            // buttonHard
            // 
            this.buttonHard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHard.Location = new System.Drawing.Point(3, 173);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(578, 30);
            this.buttonHard.TabIndex = 2;
            this.buttonHard.TabStop = false;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonMedium
            // 
            this.buttonMedium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMedium.Location = new System.Drawing.Point(3, 137);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(578, 30);
            this.buttonMedium.TabIndex = 1;
            this.buttonMedium.TabStop = false;
            this.buttonMedium.Text = "Medium";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // buttonEasy
            // 
            this.buttonEasy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEasy.Location = new System.Drawing.Point(3, 101);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(578, 30);
            this.buttonEasy.TabIndex = 0;
            this.buttonEasy.TabStop = false;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // SingleplayerDifficultyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonMedium);
            this.Controls.Add(this.buttonEasy);
            this.Name = "SingleplayerDifficultyControl";
            this.Size = new System.Drawing.Size(584, 373);
            this.ResumeLayout(false);

        }

        #endregion

        private Buttons.ButtonMedium buttonEasy;
        private Buttons.ButtonMedium buttonMedium;
        private Buttons.ButtonMedium buttonHard;
    }
}
