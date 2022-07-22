using EmpManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpManagement.Repositories
{
    public interface IEmployeeRepository
    {
        Task addAsync(Employee employee);
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeeAsync( int id);
        Task Update(Employee employee);
        Task Delete(Employee employee);

    }
}
