using EmpManagement.Contexts;
using EmpManagement.Models;

namespace EmpManagement.Repositories
{
    public class UnitOfWork : IUnitOfWork

    {
        private readonly EmpDbContext _context;

        public UnitOfWork(EmpDbContext context)
        {
           _context = context;
        }
        public async Task CompleteTask()
        {
          
            await  _context.SaveChangesAsync();    
        }

        public async Task Detach()
        {
             _context.ChangeTracker.Clear();
        }
    }
}
