using BAL;
using System;
using System.Windows.Forms;

namespace ProjectGameMVC
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }



        private void btnBackLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            LoginAccountBAL accountBAL = new LoginAccountBAL();
            if (txtUserName2.Text == "" || txtPassWord2.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu tài khoản hoặc mật khẩu");
            }
            else if (txtPassWord2.Text != txtRePass2.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại sai, Vui lòng nhập lại");
            }
            else
            {
                if (accountBAL.addUser(txtUserName2.Text, txtPassWord2.Text))
                {
                    MessageBox.Show("Đăng ký thành công");
                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản trùng");
                }

            }

        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
