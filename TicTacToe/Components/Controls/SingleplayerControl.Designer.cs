namespace TicTacToe.Components.Controls
{
    partial class SingleplayerControl
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
            this.gameBoard1 = new TicTacToe.Components.Basic.GameBoard();
            this.SuspendLayout();
            // 
            // gameBoard1
            // 
            this.gameBoard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameBoard1.Location = new System.Drawing.Point(0, 0);
            this.gameBoard1.MaximumSize = new System.Drawing.Size(300, 300);
            this.gameBoard1.MinimumSize = new System.Drawing.Size(300, 300);
            this.gameBoard1.Name = "gameBoard1";
            this.gameBoard1.Size = new System.Drawing.Size(300, 300);
            this.gameBoard1.TabIndex = 0;
            // 
            // SingleplayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gameBoard1);
            this.Name = "SingleplayerControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private Basic.GameBoard gameBoard1;
    }
}
