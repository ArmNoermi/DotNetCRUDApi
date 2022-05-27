using Latihan1API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Latihan1API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        public DbSet<Employee> Employees { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=127.0.0.1; port=3306; user=root; password= ; database=latihanapi1db")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }*/
    }
}
