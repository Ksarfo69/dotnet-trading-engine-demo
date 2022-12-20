using System.ComponentModel.DataAnnotations;

namespace TradingEngine.Models
{
    public class Ticker
    {
        [Key]
        public string Symbol { get; set; }
        public string Description { get; set; }    
    }
}
