using TradingEngine.Models;

namespace TradingEngine.Interfaces
{
    public interface ITickerRepository
    {
        ICollection<Ticker> findAll();
    }
}
