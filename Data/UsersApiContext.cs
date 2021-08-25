using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsersApi.Models;

namespace UsersApi.Data
{
    public class UsersApiContext : DbContext
    {
        public UsersApiContext (DbContextOptions<UsersApiContext> options)
            : base(options)
        {
        }

        public DbSet<UsersApi.Models.User> User { get; set; }
    }
}
