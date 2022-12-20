using System.ComponentModel.DataAnnotations;

namespace TradingEngine.Models
{
    public class AppUser
    {
        [Key]
        public string Username { get; set; }

        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Email { get; set; }
    }
}
