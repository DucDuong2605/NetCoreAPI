using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace MvcMovie.Data
{
     public class ApplicationBbContext : DbContext
    {
        public ApplicationBbContext(DbContextOptions<ApplicationBbContext> options)
            : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}