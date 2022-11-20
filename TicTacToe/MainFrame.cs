using System.Windows.Forms;
using TicTacToe.Components.Controls;

namespace TicTacToe
{
    public partial class MainFrame : Form
    {
        private UserControl current_control;

        private UserControl main_control;
        private UserControl singleplayer_control;
        private UserControl singleplayer_difficulty_control;
        private UserControl multiplayer_socket_control;
        private UserControl multiplayer_local_control;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, System.EventArgs e)
        {
            main_control = new MainMenuControl();
            main_control.Dock = DockStyle.Fill;
            panelPlaceholder.Controls.Add(main_control);

            current_control = main_control;
        }

        private void buttonMenu_Click(object sender, System.EventArgs e)
        {
            panelPlaceholder.Controls.Remove(current_control);
            panelPlaceholder.Controls.Add(main_control);
            main_control.BringToFront();
        }

        public void LoadSingleplayerDifficulty()
        {
            if (singleplayer_difficulty_control == null)
            {
                singleplayer_difficulty_control = new SingleplayerDifficultyControl();
            }

            panelPlaceholder.Controls.Remove(current_control);
            singleplayer_difficulty_control.Dock = DockStyle.Fill;
            panelPlaceholder.Controls.Add(singleplayer_difficulty_control);
            singleplayer_difficulty_control.BringToFront();
        }

        public void LoadSingleplayer(SingleplayerDifficulty difficulty, Player start_player)
        {
            singleplayer_control = new SingleplayerControl(difficulty);

            panelPlaceholder.Controls.Remove(current_control);
            singleplayer_control.Dock = DockStyle.Fill;
            panelPlaceholder.Controls.Add(singleplayer_control);
            singleplayer_control.BringToFront();

            ((SingleplayerControl)singleplayer_control).SetPlayer(start_player);
        }

        public void LoadMultiplayerLocal()
        {
            multiplayer_local_control = new MultiplayerLocalControl();

            panelPlaceholder.Controls.Remove(current_control);
            multiplayer_local_control.Dock = DockStyle.Fill;
            panelPlaceholder.Controls.Add(multiplayer_local_control);
            multiplayer_local_control.BringToFront();
        }

        public void LoadMultiplayerSocket()
        {
            multiplayer_socket_control = new MultiplayerSocketControl();

            panelPlaceholder.Controls.Remove(current_control);
            multiplayer_socket_control.Dock = DockStyle.Fill;
            panelPlaceholder.Controls.Add(multiplayer_socket_control);
            multiplayer_socket_control.BringToFront();
        }
    }
}
