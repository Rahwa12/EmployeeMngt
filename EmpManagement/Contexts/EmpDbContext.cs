using EmpManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpManagement.Contexts
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {

        }
       
       public DbSet<Employee> Employees { get; set; } 

    }
}
