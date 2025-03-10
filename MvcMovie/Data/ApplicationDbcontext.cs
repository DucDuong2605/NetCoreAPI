using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Person> Person { get; set;}
        public DbSet<Employee> Employee { get; set;}
    }
}