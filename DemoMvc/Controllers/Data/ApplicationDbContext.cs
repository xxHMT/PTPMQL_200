using DemoMvc.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {}
        public DbSet<Student> Student {get; set;}
        public DbSet<Account> Account { get; set; } = default!;
        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
    }
}