using DAL;
using System;

namespace BAL
{
    public class NameInGameBAL
    {
        NameInGameDAL nameInGameDAL = new NameInGameDAL();
        public bool checkNameGame(string UserName, String PassWord)
        {

            return nameInGameDAL.checkNameCharacter(UserName, PassWord);

        }
        public bool insertAccount(string NameCharacter, string UserName, String PassWord)
        {

            return nameInGameDAL.insertAccount(NameCharacter, UserName, PassWord);

        }
    }
}
