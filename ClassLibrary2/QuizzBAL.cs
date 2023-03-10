using ClassLibrary1;
using ClassLibrary3;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class QuizzBAL
    {
        QuizzDAL dal = new QuizzDAL();
        public List<QuizzDTO> getListQuizzs()
        {
            return dal.getListQuizz();
        }
        public bool checkID(int ID)
        {
            List<QuizzDTO> Quizz = dal.getListQuizz();
            foreach (QuizzDTO ua in Quizz)
            {
                if (ua.ID == ID)
                
                return true;
            }
            return false;
        }
        public QuizzDTO getQuizz(int id)
        {

            return dal.GetQuizz(id); ;
        }
        public int getListCount()
        {
            return dal.getListQuizzCount();
        }

    }
}
