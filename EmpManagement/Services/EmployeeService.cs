using EmpManagement.Communication;
using EmpManagement.Contexts;
using EmpManagement.Models;
using EmpManagement.Repositories;

namespace EmpManagement.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IEmployeeRepository repository , IUnitOfWork unitOfWork)
        {
           _repository = repository;
           _unitOfWork = unitOfWork;
        }
        public async Task<AddEmployeeResponse> addEmployee(Employee employee)
        {
            try
            {
                 await _repository.addAsync(employee);
                 await _unitOfWork.CompleteTask();
                return new AddEmployeeResponse(employee);
            }
            catch (Exception ex)
            {

              return new AddEmployeeResponse($"could not add employee {ex.Message}");
            }
          
           
        }

        public async Task<AddEmployeeResponse> Delete(int id)
        {
            var employee =  await _repository.GetEmployeeAsync(id);
            if (employee == null)
            {
                return new AddEmployeeResponse("Employee Not Found");
            }
            try
            {
                await _repository.Delete(employee);
                await _unitOfWork.CompleteTask();
                return new AddEmployeeResponse(employee);
            }
            catch (Exception ex)
            {

                return new AddEmployeeResponse($"Error: {ex}");
            }

        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _repository.GetEmployeeAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _repository.GetEmployeesAsync();
        }

        public async Task<AddEmployeeResponse> Update(int id, Employee employee)
        {
            var user =  await _repository.GetEmployeeAsync(id);
            
            if (user == null)
            {
                return new AddEmployeeResponse("Employee Not Found");
            }
            try
            {
                await  _unitOfWork.Detach();
                await _repository.Update(employee);
                await _unitOfWork.CompleteTask();
                return new AddEmployeeResponse(employee);
            }
            catch(Exception ex)
            {
                return new AddEmployeeResponse($"Error: {ex}");
            }
            
        }
    }
}
