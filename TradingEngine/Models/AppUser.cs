using System.ComponentModel.DataAnnotations;

namespace TradingEngine.Models
{
    public class AppUser
    {
        [Key]
        public string Username { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }
    }
}
