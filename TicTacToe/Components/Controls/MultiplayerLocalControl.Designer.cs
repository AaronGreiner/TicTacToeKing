namespace TicTacToe.Components.Controls
{
    partial class MultiplayerLocalControl
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
            this.gameBoard = new TicTacToe.Components.Basic.GameBoard();
            this.SuspendLayout();
            // 
            // gameBoard
            // 
            this.gameBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameBoard.Location = new System.Drawing.Point(0, 0);
            this.gameBoard.MaximumSize = new System.Drawing.Size(300, 300);
            this.gameBoard.MinimumSize = new System.Drawing.Size(300, 300);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(300, 300);
            this.gameBoard.TabIndex = 0;
            // 
            // SingleplayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gameBoard);
            this.Name = "SingleplayerControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private Basic.GameBoard gameBoard;
    }
}
