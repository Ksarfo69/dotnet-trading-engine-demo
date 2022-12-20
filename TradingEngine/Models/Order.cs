namespace TradingEngine.Models
{
    public class Order
    {
        public int Id { get; set; }

        public OrderType OrderType { get; set; }

        public Side Side { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
