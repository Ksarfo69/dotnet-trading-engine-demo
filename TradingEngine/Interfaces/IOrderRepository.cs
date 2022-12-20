using TradingEngine.Models;

namespace TradingEngine.Interfaces
{
    public interface IOrderRepository
    {
        ICollection<Order> findAll();
    }
}
