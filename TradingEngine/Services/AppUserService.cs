using TradingEngine.Data;
using TradingEngine.Models;
using TradingEngine.Repositories.Interfaces;
using TradingEngine.Services.Interfaces;

namespace TradingEngine.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserRepository _appUserRepository;

        public AppUserService(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        public ICollection<AppUser> fetchAllAppUsers()
        {
            return _appUserRepository.findAll();
        }
    }
}
