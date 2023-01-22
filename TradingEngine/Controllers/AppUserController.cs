using Microsoft.AspNetCore.Mvc;
using TradingEngine.Services.Interfaces;

namespace TradingEngine.Controllers
{
    [ApiController]
    [Route("api/appuser")]
    public class AppUserController : Controller
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult fetchAllAppUsers()
        {
            return Ok(_appUserService.fetchAllAppUsers());
        }
    }
}
