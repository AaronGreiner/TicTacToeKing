namespace TicTacToe.Components.Controls
{
    partial class MainMenuControl
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
            this.buttonMultiplayerSocket = new TicTacToe.Components.Buttons.ButtonMedium();
            this.buttonMultiplayerLocal = new TicTacToe.Components.Buttons.ButtonMedium();
            this.buttonSingleplayer = new TicTacToe.Components.Buttons.ButtonMedium();
            this.SuspendLayout();
            // 
            // buttonMultiplayerSocket
            // 
            this.buttonMultiplayerSocket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMultiplayerSocket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiplayerSocket.Location = new System.Drawing.Point(3, 173);
            this.buttonMultiplayerSocket.Name = "buttonMultiplayerSocket";
            this.buttonMultiplayerSocket.Size = new System.Drawing.Size(578, 30);
            this.buttonMultiplayerSocket.TabIndex = 2;
            this.buttonMultiplayerSocket.TabStop = false;
            this.buttonMultiplayerSocket.Text = "Multiplayer Socket";
            this.buttonMultiplayerSocket.UseVisualStyleBackColor = true;
            this.buttonMultiplayerSocket.Click += new System.EventHandler(this.buttonMultiplayerSocket_Click);
            // 
            // buttonMultiplayerLocal
            // 
            this.buttonMultiplayerLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMultiplayerLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiplayerLocal.Location = new System.Drawing.Point(3, 137);
            this.buttonMultiplayerLocal.Name = "buttonMultiplayerLocal";
            this.buttonMultiplayerLocal.Size = new System.Drawing.Size(578, 30);
            this.buttonMultiplayerLocal.TabIndex = 1;
            this.buttonMultiplayerLocal.TabStop = false;
            this.buttonMultiplayerLocal.Text = "Multiplayer Local";
            this.buttonMultiplayerLocal.UseVisualStyleBackColor = true;
            this.buttonMultiplayerLocal.Click += new System.EventHandler(this.buttonMultiplayerLocal_Click);
            // 
            // buttonSingleplayer
            // 
            this.buttonSingleplayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSingleplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSingleplayer.Location = new System.Drawing.Point(3, 101);
            this.buttonSingleplayer.Name = "buttonSingleplayer";
            this.buttonSingleplayer.Size = new System.Drawing.Size(578, 30);
            this.buttonSingleplayer.TabIndex = 0;
            this.buttonSingleplayer.TabStop = false;
            this.buttonSingleplayer.Text = "Singleplayer";
            this.buttonSingleplayer.UseVisualStyleBackColor = true;
            this.buttonSingleplayer.Click += new System.EventHandler(this.buttonSingleplayer_Click);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMultiplayerSocket);
            this.Controls.Add(this.buttonMultiplayerLocal);
            this.Controls.Add(this.buttonSingleplayer);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(584, 373);
            this.ResumeLayout(false);

        }

        #endregion

        private Buttons.ButtonMedium buttonSingleplayer;
        private Buttons.ButtonMedium buttonMultiplayerLocal;
        private Buttons.ButtonMedium buttonMultiplayerSocket;
    }
}
