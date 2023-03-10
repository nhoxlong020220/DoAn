using System;
using System.Windows.Forms;

namespace ProjectGameMVC
{
    public partial class MainMenuForm : Form
    {
        int countExit = 0;
        public WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public MainMenuForm()
        {
            InitializeComponent();
            try
            {
                wplayer.URL = @"C:\Users\nhoxl\source\repos\ProjectGameMVC\1.mp3";
                wplayer.controls.play();
                wplayer.settings.volume = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Game formGame = new Game();
            this.Hide();

            formGame.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            countExit++;
            if (countExit > 1)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Nhấn thêm 1 lần nữa để thoát");
            }
        }



        private void btnGameLeaderPoint_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaderForm leaderForm = new LeaderForm();
            leaderForm.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void lbNameGame_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
