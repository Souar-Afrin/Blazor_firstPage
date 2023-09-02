using Blazor_firstPage.Server.Model;
using Blazor_firstPage.Server.Service.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_firstPage.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserServiceController : ControllerBase
    {
        public List<User> Users { get; set; }
        public UserService UserService { get; set; }

        private readonly ILogger<UserServiceController> _logger;

        public UserServiceController(UserService userService, ILogger<UserServiceController> _logger)
        {
            this.UserService = userService;
            this._logger = _logger;
        }
   
        [HttpGet]
        public IActionResult OnGet()
        {
            Users = UserService.GetUsers(); 
            return Ok(Users);
        }
       
    }
}
