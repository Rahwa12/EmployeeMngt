using EmpManagement.Communication;
using EmpManagement.Models;

namespace EmpManagement.Services
{
    public interface IEmployeeService
    {
        Task<AddEmployeeResponse> addEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<AddEmployeeResponse> Update(int id, Employee employee);
        Task<AddEmployeeResponse> Delete(int id);
    }
}
