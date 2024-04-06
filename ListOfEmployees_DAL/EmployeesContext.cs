using ListOfEmployees__DomainModel;
using Microsoft.EntityFrameworkCore;

namespace ListOfEmployees_DAL
{
    public class EmployeesContext:DbContext
    {
       public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           base.OnConfiguring(optionsBuilder);

        }

        public EmployeesContext(DbContextOptions<EmployeesContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
