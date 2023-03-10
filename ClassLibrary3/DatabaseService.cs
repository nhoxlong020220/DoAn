using System;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseService
    {
        public string connectionString = "server=DARKNESS; database=LoginDB;integrated security=true"; // Câu lệnh kết nối đến db
        // nho bo @ 
        public SqlConnection connection = new SqlConnection(); // khai báo  kiểu dữ liệu kết nối đến db
        public SqlCommand command; // khai báo kiểu dữ liệu thao tác lên db

        public void OpenConnection() // Mở kết nối db
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Closed)
            // nếu connection khác null và connection đang đóng
            {
                // thì connection kết nối đến db thông qua connectionString và mở kết nối
                connection.ConnectionString = connectionString;
                connection.Open();
            }
        }
        public void CloseConnection() // Ngắt kết nối db
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            // nếu connection khác null và connection đang mở
            {
                // thì đóng kết nối đến db
                connection.Close();
            }
        }
        public SqlDataReader ReadData(string sql) // Đọc data không có tham số

        {
            // khai báo command dưới dạng dư liệu SqlCommand
            command = new SqlCommand();
            // thể loại command là text
            command.CommandType = System.Data.CommandType.Text;
            // gán command = sql
            command.CommandText = sql;
            // kết nối đến db
            command.Connection = connection;
            OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            // thực thi kiểu dữ liệu SqlDataReader bằng hàm command.ExecuteReader()
            return reader;

        }

        public SqlDataReader ReadDataPars(string sql, SqlParameter[] Pars) // Đọc data có tham số
        {
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            command.Parameters.AddRange(Pars);
            // Truyền tham số Pars
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public bool WriteData(String sql, SqlParameter[] pars) // insert data 
        {
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            command.Parameters.AddRange(pars);
            int kq = command.ExecuteNonQuery();
            // thực thi không trả về giá trị

            return kq > 0;
        }
    }
}
