using TradingEngine.Models;

namespace TradingEngine.Interfaces
{
    public interface IAppUserRepository
    {
        ICollection<AppUser> findAll();
    }
}
