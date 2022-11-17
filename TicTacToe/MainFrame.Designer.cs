namespace TicTacToe
{
    partial class MainFrame
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPlaceholder = new System.Windows.Forms.Panel();
            this.buttonMenu = new TicTacToe.Components.Buttons.ButtonSmall();
            this.SuspendLayout();
            // 
            // panelPlaceholder
            // 
            this.panelPlaceholder.Location = new System.Drawing.Point(0, 39);
            this.panelPlaceholder.Name = "panelPlaceholder";
            this.panelPlaceholder.Size = new System.Drawing.Size(584, 382);
            this.panelPlaceholder.TabIndex = 3;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Image = global::TicTacToe.Properties.Resources.menu;
            this.buttonMenu.Location = new System.Drawing.Point(4, 4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(30, 30);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.panelPlaceholder);
            this.Controls.Add(this.buttonMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 460);
            this.MinimumSize = new System.Drawing.Size(600, 460);
            this.Name = "MainFrame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Buttons.ButtonSmall buttonMenu;
        private System.Windows.Forms.Panel panelPlaceholder;
    }
}