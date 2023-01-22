using TradingEngine.Data;
using TradingEngine.Models;

namespace TradingEngine.Repositories.Interfaces
{
    public interface IPortfolioRepository
    {
        ICollection<Portfolio> findAll();
    }
}
