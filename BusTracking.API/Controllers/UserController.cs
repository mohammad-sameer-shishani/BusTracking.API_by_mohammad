using BusTracking.Core.Data;
using BusTracking.Core.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTracking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<User>> GetAllUser()
        {
            return await _userService.GetAllUser();
        }
        [HttpGet]
        [Route("GetAllTeachers")]
        public async Task<List<User>> GetAllTeachers()
        {
            return await _userService.GetAllTeachers();
        }
        [HttpGet]
        [Route("GetAllDrivers")]
        public async Task<List<User>> GetAllDrivers()
        {
            return await _userService.GetAllDrivers();
        }
        [HttpGet]
        [Route("GetAllParents")]
        public async Task<List<User>> GetAllParents()
        {
            return await _userService.GetAllParents();
        }

        [HttpGet("{userId}")]
        public async Task<User> GetUserById(int userId)
        {
            return await _userService.GetUserById(userId);
        }

        [HttpPost]
        public async Task CreateUser(User user)
        {
            await _userService.CreateUser(user);
        }

        [HttpPut]
        public async Task UpdateUser(User user)
        {
            await _userService.UpdateUser(user);
        }

        [HttpDelete]
        public async Task DeleteUser(int userid)
        {
            await _userService.DeleteUser(userid);
        }


    }
}
