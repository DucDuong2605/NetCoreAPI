using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace MvcMovie.Data
{

    namespace MvcMovie.Data
    {
        public class ApplicationDbcontext : DbContext
        {
            public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
            { }
            public Dbset<Person> Persons { get; set; }
            public DbSet<Employee> Employee{get;set;}
        }
    }
}