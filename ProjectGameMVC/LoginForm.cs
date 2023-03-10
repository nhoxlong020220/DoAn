using BAL;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectGameMVC
{
    public partial class LoginForm : Form
    {
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public LoginForm()
        {
            InitializeComponent();
            /*  try
              {
                  wplayer.URL = @"C:\Users\nhoxl\source\repos\ProjectGameMVC\1.mp3";
                  wplayer.controls.play();
                  wplayer.settings.volume = 100;
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message, "Error playing sound");
              }*/
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginAccountBAL accountBAL = new LoginAccountBAL();
            NameInGameBAL nameInGameBAL = new NameInGameBAL();
            if (txtUsername.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu tài khoản hoặc mật khẩu");
            }
            if (accountBAL.checkLogin(txtUsername.Text, txtPassWord.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                MainMenuForm mainMenu = new MainMenuForm();
                /* if (nameInGameBAL.checkNameGame(txtUsername.Text, txtPassWord.Text) == false)
                 {
                     wplayer.close();
                     this.Hide();
                     CreateName createName = new CreateName();
                     createName.Show();

                 }*/

                wplayer.close();
                this.Hide();
                mainMenu.Show();


            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn bị sai ");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void llbCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            wplayer.close();
            CreateForm form2 = new CreateForm();
            form2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
