using BAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjectGameMVC
{
    public partial class LeaderForm : Form
    {
        public LeaderForm()
        {
            InitializeComponent();
        }
        LoginAccountBAL accountBAL = new LoginAccountBAL();
        private void dgvHighScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BindGrid(List<LoginAccountDTO> listUsers)
        {
            dgvHighScore.Rows.Clear();
            foreach (var item in listUsers)
            {
                int index = dgvHighScore.Rows.Add();
                dgvHighScore.Rows[index].Cells[0].Value = index + 1;
                dgvHighScore.Rows[index].Cells[1].Value = item.UserName;
                dgvHighScore.Rows[index].Cells[2].Value = item.Score;
            }
        }
        private void LeaderForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<LoginAccountDTO> listUsers = accountBAL.getListAccounts();
                foreach (var item in listUsers)
                {

                    if (item.Score == 0)
                    {
                        item.Score = 0;
                    }
                }
                BindGrid(listUsers.OrderByDescending(p => p.Score).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnBackLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm =   new LoginForm();
            loginForm.Show();
        }
    }
}
