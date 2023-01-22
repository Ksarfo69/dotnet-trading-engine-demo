using TradingEngine.Models;

namespace TradingEngine.Services.Interfaces
{
    public interface IAppUserService
    {
        ICollection<AppUser> fetchAllAppUsers();
    }
}
