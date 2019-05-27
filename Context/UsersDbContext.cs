using Microsoft.EntityFrameworkCore;
using StoreService.Models;

namespace StoreService.Context
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> opt)
            : base(opt) { }

        public DbSet<User> Users { get; set; }
    }
}
