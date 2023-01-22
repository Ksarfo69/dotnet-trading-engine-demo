using TradingEngine.Data;
using TradingEngine.Models;
using TradingEngine.Repositories.Interfaces;

namespace TradingEngine.Repositories
{
    public class TickerRepository: ITickerRepository
    {
        private readonly DataContext _context;

        public TickerRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Ticker> findAll()
        {
           return _context.Tickers.OrderBy(ticker => ticker.Symbol).ToList();
        }
    }
}
