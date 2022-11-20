using System.Windows.Forms;

namespace TicTacToe.Components.Controls
{
    public partial class SingleplayerDifficultyControl : UserControl
    {
        private Player start_player;

        public SingleplayerDifficultyControl()
        {
            InitializeComponent();
            start_player = Player.Cross;
            radioButtonSelectUser.Checked = true;
        }

        private void buttonEasy_Click(object sender, System.EventArgs e)
        {
            Program.MainApplicationFrame.LoadSingleplayer(SingleplayerDifficulty.Easy, start_player);
        }

        private void buttonMedium_Click(object sender, System.EventArgs e)
        {
            Program.MainApplicationFrame.LoadSingleplayer(SingleplayerDifficulty.Medium, start_player);
        }

        private void buttonHard_Click(object sender, System.EventArgs e)
        {
            Program.MainApplicationFrame.LoadSingleplayer(SingleplayerDifficulty.Hard, start_player);
        }

        private void radioButtonSelectUser_CheckedChanged(object sender, System.EventArgs e)
        {
            start_player = Player.Cross;
        }

        private void radioButtonSelectCom_CheckedChanged(object sender, System.EventArgs e)
        {
            start_player = Player.Circle;
        }
    }
}
