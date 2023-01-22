using TradingEngine.Data;
using TradingEngine.Models;
using TradingEngine.Repositories.Interfaces;

namespace TradingEngine.Repositories
{
    public class PortfolioRepository: IPortfolioRepository
    {
        private readonly DataContext _context;

        public PortfolioRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Portfolio> findAll()
        {
            return _context.Portfolios.OrderBy(portfolio => portfolio.Id).ToList();
        }
    }
}
