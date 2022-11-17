using Microsoft.EntityFrameworkCore;
using testsqlite.Models;

namespace testsqlite.DataAccess
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<User>   User { get; set; }
    }
}
