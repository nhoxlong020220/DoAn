using DAL;
using DTO;
using System.Collections.Generic;

namespace BAL
{
    public class LoginAccountBAL
    {
        /*   LoginAccountDAL loginAccountDAL = new LoginAccountDAL();
           public bool checkAccount(string UserName, String PassWord)
           {

               return loginAccountDAL.checkAccount(UserName, PassWord);
           }
           public int getID(string UserName, String PassWord)
           {

               return loginAccountDAL.getID(UserName, PassWord);
           }
       }*/


        AccountDAL dal = new AccountDAL();
        public List<LoginAccountDTO> getListAccounts()
        {
            return dal.getListAccounts();
        }
        public bool checkLogin(string UserName, string Password)
        {
            List<LoginAccountDTO> userAccounts = dal.getListAccounts();
            foreach (LoginAccountDTO ua in userAccounts)
            {
                if (ua.UserName == UserName && ua.Password == Password)
                    return true;
            }
            return false;
        }
        public LoginAccountDTO getUser(int id)
        {
            return dal.GetAccount(id);
        }
        public bool addUser(string UserName, string Password)
        {
            List<LoginAccountDTO> userAccounts = dal.getListAccounts();
            foreach (LoginAccountDTO ua in userAccounts)
            {
                if (ua.UserName == UserName)
                    return false;
            }
            string json = dal.AddAccount(UserName, Password);
            if (json != null)
            {
                return true;
            }
            return false;
        }
        public void updateUser(int id, int time)
        {
            dal.UpdateAccount(id, time);
        }
    }
}

