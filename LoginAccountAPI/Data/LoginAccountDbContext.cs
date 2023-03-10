using LoginAccountAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LoginAccountAPI.Data
{
    public class LoginAccountDbContext : DbContext
    {
        public LoginAccountDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<LoginAcount> accountInfos { get; set; }
    }
}
