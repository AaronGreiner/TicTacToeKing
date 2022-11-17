using System.Windows.Forms;

namespace TicTacToe.Components.Controls
{
    public partial class MainMenuControl : UserControl
    {
        public MainMenuControl()
        {
            InitializeComponent();
        }

        private void buttonSingleplayer_Click(object sender, System.EventArgs e)
        {
            Program.MainApplicationFrame.LoadSingleplayer();
        }

        private void buttonMultiplayerLocal_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonMultiplayerSocket_Click(object sender, System.EventArgs e)
        {

        }
    }
}
