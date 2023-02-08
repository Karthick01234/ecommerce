using ecommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.data
{
    public class DB : IdentityDbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {
        }
        public DbSet<User> User{ get; set; }
    }
}
