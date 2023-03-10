namespace LoginAccountAPI.Models
{
    public class UpdateAccountRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Score { get; set; }
    }
}
