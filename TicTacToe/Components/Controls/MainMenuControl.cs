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
            Program.MainApplicationFrame.LoadSingleplayerDifficulty();
        }

        private void buttonMultiplayerLocal_Click(object sender, System.EventArgs e)
        {
            Program.MainApplicationFrame.LoadMultiplayerLocal();
        }

        private void buttonMultiplayerSocket_Click(object sender, System.EventArgs e)
        {
            Program.MainApplicationFrame.LoadMultiplayerSocket();
        }
    }
}
