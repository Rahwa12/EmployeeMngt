using EmpManagement.Contexts;
using EmpManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmpDbContext _context;

        public EmployeeRepository(EmpDbContext context)
        {
            _context = context;
        }
        public  async Task addAsync(Employee employee)
        {
           await _context.Employees.AddAsync(employee);
            
        }

        public async Task Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            return  _context.Employees.Where(e => e.Id == id).FirstOrDefault();
        }

        public async Task< IEnumerable<Employee>> GetEmployeesAsync()
        {
            return _context.Employees.ToList();
        }

        public async Task Update(Employee employee)
        {
            
            _context.Employees.Update(employee);
        }
    }
}
