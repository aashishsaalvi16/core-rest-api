using core_rest_api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_rest_api.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<ApplicationUser>> GetAllUsers();

        public Task<ApplicationUser> GetUserByEmail(string email);

        public Task<ApplicationUser> GetUserById(string id);
    }

    public class UserService : IUserService
    {
        private readonly MyDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(MyDbContext dbContext,
                                UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            return await _dbContext.Users.OrderBy(u => u.FirstName).ToListAsync();
        }

        public async Task<ApplicationUser> GetUserById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public async Task<ApplicationUser> GetUserByEmail(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
