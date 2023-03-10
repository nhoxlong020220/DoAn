using DTO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;



namespace DAL
{
    public class AccountDAL
    {
        public List<LoginAccountDTO> getListAccounts()
        {
            WebClient webClient = new WebClient();
            string json = webClient.DownloadString("http://14.225.254.176:7000/getUsers");
            List<LoginAccountDTO> listAccounts = JsonConvert.DeserializeObject<List<LoginAccountDTO>>(json);
            return listAccounts;
        }
        public string AddAccount(string username, string password)
        {
            WebClient webClient = new WebClient();
            var data = new
            {
                Username = username,
                Password = password
            };
            string jsonData = JsonConvert.SerializeObject(data);
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            string json = webClient.UploadString("http://14.225.254.176:7000/api/Users", jsonData);
            return json;
        }
        public LoginAccountDTO GetAccount(int id)
        {
            WebClient webClient = new WebClient();
            string json = webClient.DownloadString("http://14.225.254.176:7000/api/Users/" + id);
            LoginAccountDTO accountDTO = JsonConvert.DeserializeObject<LoginAccountDTO>(json);
            return accountDTO;
        }
        public void UpdateAccount(int id, int Score)
        {
            WebClient webClient = new WebClient();
            var data = new
            {
                Score = Score,
            };
            string jsonData = JsonConvert.SerializeObject(data);
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            string json = webClient.UploadString("http://14.225.254.176:7000/api/Users/" + id, jsonData);
        }

    }
}

