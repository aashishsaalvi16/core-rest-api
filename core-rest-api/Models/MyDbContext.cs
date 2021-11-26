using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_rest_api.Models
{
    public class MyDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {

        }
    }
}
