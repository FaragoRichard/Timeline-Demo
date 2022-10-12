using Microsoft.EntityFrameworkCore;
using TimelineDemoAPI.Models;

namespace TimelineDemoAPI.Data
{
    public class TimelineDemoDbContext : DbContext
    {
        public DbSet<UserModel>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=D:\Temp\TimelineDemo.db");
        }
    }
}
