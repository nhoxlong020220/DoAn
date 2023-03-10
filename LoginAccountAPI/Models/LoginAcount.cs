namespace LoginAccountAPI.Models
{
    public class LoginAcount
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Score { get; set; }
    }
}
