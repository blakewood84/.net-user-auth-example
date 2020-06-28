using Microsoft.EntityFrameworkCore;
using secfromscratch.Models;

namespace secfromscratch.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options){

        }
        public DbSet<User> Users{get; set;}
    }
}