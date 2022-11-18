using System.Windows.Forms;

namespace TicTacToe.Components.Controls
{
    public partial class SingleplayerDifficultyControl : UserControl
    {
        public SingleplayerDifficultyControl()
        {
            InitializeComponent();
        }

        private void buttonEasy_Click(object sender, System.EventArgs e)
        {
            Program.MainApplicationFrame.LoadSingleplayer(SingleplayerDifficulty.Easy);
        }

        private void buttonMedium_Click(object sender, System.EventArgs e)
        {
            Program.MainApplicationFrame.LoadSingleplayer(SingleplayerDifficulty.Medium);
        }

        private void buttonHard_Click(object sender, System.EventArgs e)
        {
            Program.MainApplicationFrame.LoadSingleplayer(SingleplayerDifficulty.Hard);
        }
    }
}
