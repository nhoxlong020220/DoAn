using DTO;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class NameInGameDAL : DatabaseService
    {
        NameInGameDTO nameInGame = new NameInGameDTO();
        LoginAccountDAL loginAccount = new LoginAccountDAL();

        public bool checkNameCharacter(string UserName, String PassWord)
        {
            bool kq = false;
            try
            {
                if (loginAccount.getID(UserName, PassWord) != -1)
                {
                    string sql = "Select NameCharacter from dbo.GameCharacter where ID=@ID ";
                    SqlParameter parID = new SqlParameter("@ID", System.Data.SqlDbType.Int);
                    parID.Value = loginAccount.getID(UserName, PassWord);

                    SqlDataReader reader = ReadDataPars(sql, new[] { parID });

                    if (reader.Read())
                    {
                        kq = true;
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return kq;
        }
        public bool insertAccount(string NameCharacter, string UserName, string PassWord)
        {
            int ID = loginAccount.getID(UserName, PassWord);
            bool kq = false;
            try
            {
                String sql = " Insert into dbo.GameCharacter (NameCharacter,ID)values(@NameCharacter,@ID)";
                SqlParameter parNameCharacter = new SqlParameter("@NameCharacter", NameCharacter);
                SqlParameter parID = new SqlParameter("@ID", ID);
                kq = WriteData(sql, new[] { parNameCharacter });
                return kq;
            }
            finally
            {
                CloseConnection();
            }
            return kq;
        }

    }
}
