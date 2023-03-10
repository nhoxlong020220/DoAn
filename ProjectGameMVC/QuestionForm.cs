using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;

namespace ProjectGameMVC
{
    public partial class QuestionForm : Form
    {
        int ID = 0;
        public bool flagCon = false;
        bool flag = false;
        string _connectionString = "server=DARKNESS; database=Quizz;integrated security=true";
        //SqlConnection sqlConnection = new SqlConnection("server = DARKNESS; database=Quizz;integrated security = true");
        SqlConnection sqlConnection = null;
        public QuestionForm()
        {
            InitializeComponent();
            flag = true;
            flagCon = true;

        }

        public QuestionForm(bool data)
        {
            InitializeComponent();
            flagCon = data;
        }

        List<int> listRandID = new List<int>();

        List<int> listRandAnswer = new List<int>();

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void flagggg()
        {
            flagCon = true;
        }
        int ShowQuestion()
        {

            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(_connectionString);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            ID = RandomQuestion(1, 6);


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;

            sqlCommand.CommandText = "Select Question, A, B, C, D From dbo.Question Where ID=@ID";

            SqlParameter sqlParameter = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameter.Value = ID;
            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.Connection = sqlConnection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                String Question = reader.GetString(0);
                int A1 = RandomAnswer(1, 5);
                String A = reader.GetString(A1);
                int B1 = RandomAnswer(1, 5);
                String B = reader.GetString(B1);
                int C1 = RandomAnswer(1, 5);
                String C = reader.GetString(C1);
                int D1 = RandomAnswer(1, 5);
                String D = reader.GetString(D1);
                lbQuestion.Text = Question;
                btnAnswer1.Text = A;
                btnAnswer2.Text = B;
                btnAnswer3.Text = C;
                btnAnswer4.Text = D;

            }
            reader.Close();
            return ID;
        }





        private int RandomQuestion(int v1, int v2)
        {
            Random rand = new Random();
            int temp = -1;
            do
            {
                temp = rand.Next(v1, v2);
                if (listRandID.Contains(temp) == false)
                {
                    listRandID.Add(temp);
                    break;
                }
            } while (listRandID.Contains(temp) == true);
            return temp;
        }
        private int RandomAnswer(int v1, int v2)
        {
            Random rand = new Random();
            int temp = -1;
            do
            {
                temp = rand.Next(v1, v2);
                if (listRandAnswer.Contains(temp) == false)
                {
                    listRandAnswer.Add(temp);
                    break;
                }
            } while (listRandAnswer.Contains(temp) == true);
            return temp;
        }








        public void QuestionForm_Load(object sender, EventArgs e)
        {

            ShowQuestion();

        }

        private void btnAnswer1_Click_1(object sender, EventArgs e)
        {

            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(_connectionString);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Question, A, B, C, D From dbo.Question Where ID=@ID";

            SqlParameter sqlParameter = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameter.Value = ID;
            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.Connection = sqlConnection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            //  var IDs = reader["A"]as string;
            if (reader.Read())
            {
                if (btnAnswer1.Text == reader["A"] as string)
                {
                    MessageBox.Show("Đáp án đúng");


                    this.flagCon = true;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Đáp án sai");
                    this.Close();
                }
            }
            reader.Close();
        }

        private void btnAnswer2_Click_1(object sender, EventArgs e)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(_connectionString);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Question, A, B, C, D From dbo.Question Where ID=@ID";

            SqlParameter sqlParameter = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameter.Value = ID;
            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.Connection = sqlConnection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                if (btnAnswer2.Text == reader["A"] as string)
                {
                    MessageBox.Show("Đáp án đúng");

                    this.flagCon = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đáp án sai");
                    this.Close();
                }
            }

            reader.Close();
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(_connectionString);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Question, A, B, C, D From dbo.Question Where ID=@ID";

            SqlParameter sqlParameter = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameter.Value = ID;
            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.Connection = sqlConnection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                if (btnAnswer3.Text == reader["A"] as string)
                {
                    MessageBox.Show("Đáp án đúng");
                    this.flagCon = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đáp án sai");
                    this.Close();
                }
            }
            reader.Close();
        }

        private void btnAnswer4_Click_1(object sender, EventArgs e)
        {

            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(_connectionString);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Question, A, B, C, D From dbo.Question Where ID=@ID";

            SqlParameter sqlParameter = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameter.Value = ID;
            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.Connection = sqlConnection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                if (btnAnswer4.Text == reader["A"] as string)
                {
                    MessageBox.Show("Đáp án đúng");

                    this.flagCon = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đáp án sai");
                    this.Close();
                }
            }
            reader.Close();
        }
    }

}

