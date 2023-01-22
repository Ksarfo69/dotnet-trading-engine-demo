using TradingEngine.Data;
using TradingEngine.Models;
using TradingEngine.Repositories.Interfaces;

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
