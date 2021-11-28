using core_rest_api.Models;
using core_rest_api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAllUsers")]
        //[Route("[action]")]
        //[Route("api/Users/GetAllUsers")]
        public async Task<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            return await _userService.GetAllUsers();
        }

        [HttpGet("GetUserById/{id}")]
        //[Route("[action]")]
        //[Route("api/Users/GetUserById")]
        public async Task<ApplicationUser> GetUserById(string id)
        {
            return await _userService.GetUserById(id);
        }

        [HttpGet("GetUserByEmail/{email}")]
        //[Route("[action]")]
        //[Route("api/Users/GetUserByEmail")]
        public async Task<ApplicationUser> GetUserByEmail(string email)
        {
            return await _userService.GetUserByEmail(email);
        }
    }
}
