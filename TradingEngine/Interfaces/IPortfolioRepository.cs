using TradingEngine.Data;
using TradingEngine.Models;

namespace TradingEngine.Interfaces
{
    public interface IPortfolioRepository
    {
        ICollection<Portfolio> findAll();
    }
}
