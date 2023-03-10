using ClassLibrary1;
using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class QuizzDAL
    {
        public List<QuizzDTO> getListQuizz()
        {
            WebClient webClient = new WebClient();
            string json = webClient.DownloadString("http://14.225.254.176:7070/getQuestions");
            List<QuizzDTO> listQuizz = JsonConvert.DeserializeObject<List<QuizzDTO>>(json);
            return listQuizz;
        }
   
        public QuizzDTO GetQuizz(int id)
        {
            WebClient webClient = new WebClient();
            string json = webClient.DownloadString("http://14.225.254.176:7070/api/Question/" + id);
            QuizzDTO quizzDTO = JsonConvert.DeserializeObject<QuizzDTO>(json);
            return quizzDTO;
        }
        public int getListQuizzCount()
        {
            WebClient webClient = new WebClient();
            string json = webClient.DownloadString("http://14.225.254.176:7070/getQuestions");
            List<QuizzDTO> listQuizz = JsonConvert.DeserializeObject<List<QuizzDTO>>(json);
            return listQuizz.Count;
        }

    }
}
