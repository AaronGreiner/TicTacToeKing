namespace TicTacToe.Components
{
    partial class MainControl
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
            this.btnLocalMultiplayer = new System.Windows.Forms.Button();
            this.btnSocketMultiplayer = new System.Windows.Forms.Button();
            this.btnSingleplayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLocalMultiplayer
            // 
            this.btnLocalMultiplayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalMultiplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalMultiplayer.Location = new System.Drawing.Point(3, 44);
            this.btnLocalMultiplayer.Name = "btnLocalMultiplayer";
            this.btnLocalMultiplayer.Size = new System.Drawing.Size(248, 35);
            this.btnLocalMultiplayer.TabIndex = 1;
            this.btnLocalMultiplayer.TabStop = false;
            this.btnLocalMultiplayer.Text = "Local Multiplayer";
            this.btnLocalMultiplayer.UseVisualStyleBackColor = true;
            // 
            // btnSocketMultiplayer
            // 
            this.btnSocketMultiplayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSocketMultiplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSocketMultiplayer.Location = new System.Drawing.Point(3, 85);
            this.btnSocketMultiplayer.Name = "btnSocketMultiplayer";
            this.btnSocketMultiplayer.Size = new System.Drawing.Size(248, 35);
            this.btnSocketMultiplayer.TabIndex = 2;
            this.btnSocketMultiplayer.TabStop = false;
            this.btnSocketMultiplayer.Text = "Socket Multiplayer";
            this.btnSocketMultiplayer.UseVisualStyleBackColor = true;
            // 
            // btnSingleplayer
            // 
            this.btnSingleplayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSingleplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSingleplayer.Location = new System.Drawing.Point(3, 3);
            this.btnSingleplayer.Name = "btnSingleplayer";
            this.btnSingleplayer.Size = new System.Drawing.Size(248, 35);
            this.btnSingleplayer.TabIndex = 0;
            this.btnSingleplayer.TabStop = false;
            this.btnSingleplayer.Text = "Singleplayer";
            this.btnSingleplayer.UseVisualStyleBackColor = true;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSingleplayer);
            this.Controls.Add(this.btnSocketMultiplayer);
            this.Controls.Add(this.btnLocalMultiplayer);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(254, 139);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocalMultiplayer;
        private System.Windows.Forms.Button btnSocketMultiplayer;
        private System.Windows.Forms.Button btnSingleplayer;
    }
}
