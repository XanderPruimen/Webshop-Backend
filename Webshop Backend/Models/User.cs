namespace Webshop_Backend.Models
{
    public class User
    {
        public int AccountID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
