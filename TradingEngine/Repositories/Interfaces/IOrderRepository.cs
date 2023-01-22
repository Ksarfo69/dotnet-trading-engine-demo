using TradingEngine.Models;

namespace TradingEngine.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        ICollection<Order> findAll();
    }
}
