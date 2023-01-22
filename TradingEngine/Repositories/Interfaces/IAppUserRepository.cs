using TradingEngine.Models;

namespace TradingEngine.Repositories.Interfaces
{
    public interface IAppUserRepository
    {
        ICollection<AppUser> findAll();
    }
}
