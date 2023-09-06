using Blazor_firstPage.Server.Service.UserService;
using Blazor_firstPage.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_firstPage.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateUserController : ControllerBase
    {
        [BindProperty]
        public User user { get; set; }

        public String name { get; set; }
        public UserService UserService { get; set; }

        private readonly ILogger<CreateUserController> _logger;

        public CreateUserController(UserService userService, ILogger<CreateUserController> _logger)
        {
            this.UserService = userService;
            this._logger = _logger;
        }

        [HttpGet]
        public void Get()
        {
        }

        [HttpPost]
        public IActionResult OnPost()
        {
            UserService.AddUser(new Shared.User(user.Id, user.Name, user.Email));

            UserService.AddUser(user);
            return Ok(user);
            //if (user == null)
            //{
            //    return BadRequest(
            //        new
            //        {
            //            message = "user is null"
            //        });
            //}
            //else
            //{
            //    //Users.Add(user);
            //    UserService.AddUser(user);
            //    return Ok(user);
            //}
        }
    }
}