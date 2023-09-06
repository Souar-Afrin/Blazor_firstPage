using Blazor_firstPage.Shared;
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

        [HttpPost]
        public IActionResult OnPost(User user)
        {
            if (user == null)
            {
                return BadRequest(
                    new
                    {
                        message = "user is null"
                    });
            }
            else
            {
                //Users.Add(user);
                UserService.AddUser(user);
                return Ok(user);
            }
        }
    }
}