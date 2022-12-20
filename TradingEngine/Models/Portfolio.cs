namespace TradingEngine.Models
{
    public class Portfolio
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; } 

        public AppUser AppUser { get; set; }    
    }
}
