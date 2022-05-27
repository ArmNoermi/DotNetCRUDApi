using Latihan1API.Models;
using System.Linq;

namespace Latihan1API.Data
{
    public class DBInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return; // DB has already been seeded
            }

           var temperature = new Employee[]{
               new Employee{Name="Amin"},
                new Employee{Name="Johan"},
                new Employee{Name="Joko"}

            };
            foreach (Employee t in temperature)
            {
                context.Employees.Add(t);
            }
            context.SaveChanges();
        }
    }
}
