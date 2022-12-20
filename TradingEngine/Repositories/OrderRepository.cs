using TradingEngine.Data;
using TradingEngine.Models;

namespace TradingEngine.Repositories
{
    public class OrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Order> findAll()
        {
            return _context.Orders.OrderBy(order => order.Id).ToList();
        }
    }
}
