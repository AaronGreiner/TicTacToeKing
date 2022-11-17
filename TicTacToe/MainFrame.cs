using System.Windows.Forms;
using TicTacToe.Components.Controls;

namespace TicTacToe
{
    public partial class MainFrame : Form
    {
        private UserControl current_control;

        private UserControl main_control;
        private UserControl singleplayer_control;
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

        public void LoadSingleplayer()
        {
            if (singleplayer_control == null)
            {
                singleplayer_control = new SingleplayerControl();
            }

            panelPlaceholder.Controls.Remove(current_control);
            singleplayer_control.Dock = DockStyle.Fill;
            panelPlaceholder.Controls.Add(singleplayer_control);
            singleplayer_control.BringToFront();
        }
    }
}
