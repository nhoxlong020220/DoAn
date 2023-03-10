using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginAccountDAL : DatabaseService
    {
        LoginAccountDTO loginAccDTO = new LoginAccountDTO(); // khai báo class LoginAccountDTO
        NameInGameDTO nameInGame = new NameInGameDTO();// khai báo class NameInGameDTO

        public bool checkAccount(string UserName, string PassWord)// hàm kiểm tra tk
        {
            bool kq = false;
            try
            {

                string sql = "Select * from dbo.LoginAccount where UserName=@UserName and PassWord=@PassWord";
                // lấy tất cả các thuộc tính trong db ở bảng LoginAccount nơi mà UserName=@UserName and PassWord=@PassWord
                SqlParameter parUser = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);

                parUser.Value = UserName;
                SqlParameter parPass = new SqlParameter("@PassWord", System.Data.SqlDbType.VarChar);
                parPass.Value = PassWord;
                SqlDataReader reader = ReadDataPars(sql, new[] { parUser, parPass });

                if (reader.Read())
                {
                    kq = true;

                }
            }
            finally
            {
                CloseConnection();
            }
            return kq;

        }
        public int getID(string UserName, string PassWord)
        {
            int ID = -1;
            try
            {
                string sql = "Select * from dbo.LoginAccount where UserName=@UserName and PassWord=@PassWord";

                SqlParameter parUser = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);

                parUser.Value = UserName;

                SqlParameter parPass = new SqlParameter("@PassWord", System.Data.SqlDbType.VarChar);

                parPass.Value = PassWord;

                SqlDataReader reader = ReadDataPars(sql, new[] { parUser, parPass });

                if (reader.Read())
                {
                    ID = reader.GetInt32(0);
                }

            }
            finally
            {
                CloseConnection();
            }
            return ID;

        }




    }
}
