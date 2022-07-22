using EmpManagement.Models;

namespace EmpManagement.Communication
{
    public class AddEmployeeResponse
    {
        public bool IsSuccess;
        public string Message;
        public Employee Employee;

        private AddEmployeeResponse(bool isSuccess , string message, Employee employee)
        {
            IsSuccess = isSuccess;
            Message = message;  
            Employee = employee;    
        }
        public AddEmployeeResponse(string message):this(false,message,null)
        {

        }
        public AddEmployeeResponse(Employee employee):this(true,String.Empty,employee)  
        {

        }
    }
}
