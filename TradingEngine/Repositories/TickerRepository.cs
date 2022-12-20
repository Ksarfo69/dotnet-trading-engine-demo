using TradingEngine.Data;
using TradingEngine.Interfaces;
using TradingEngine.Models;

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
