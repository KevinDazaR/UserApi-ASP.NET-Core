using UserApi.Models;
using Microsoft.EntityFrameworkCore;

namespace UserApi.Infraestructure.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}