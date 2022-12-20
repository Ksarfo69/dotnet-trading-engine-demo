using TradingEngine.Data;
using TradingEngine.Interfaces;
using TradingEngine.Models;

namespace TradingEngine.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly DataContext _context;

        public AppUserRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<AppUser> findAll()
        {
            return _context.AppUsers.OrderBy(appUser => appUser.Username).ToList();
        }
    }
}
