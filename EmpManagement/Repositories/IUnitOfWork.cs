using EmpManagement.Models;

namespace EmpManagement.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteTask();
        Task Detach();
    }
}
