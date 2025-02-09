using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using LearningManagementSystem.DataBase.Models;
using LearningManagementSystem.DataBase.Data;
using LearningManagementSystem.Domain.Service.UsersServices;
using LearningManagementSystem.Domain.ViewModels;

namespace LearningManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("Login")]
        public IActionResult HelloWorld()
        {
            return Ok("Hello Worlds");
        }

        [HttpPost("Register")]
        public IActionResult CreateUser(UsersViewModels user)
        {
            var items = _userRepository.CreateUser(user);

            return Ok(items);
        }

    }
}
