using TradingEngine.Models;

namespace TradingEngine.Repositories.Interfaces
{
    public interface ITickerRepository
    {
        ICollection<Ticker> findAll();
    }
}
