using AutoMapper;
using EmpManagement.Models;
using EmpManagement.Resources;
using EmpManagement.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmpManagement.Controllers
{
    //[Route("api/[controller]")]
        [Route("api/Employees")]

    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService ,IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeService.GetEmployees();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var emp = await _employeeService.GetEmployee(id);
            if (emp != null)
            {
                return Ok(emp);
            }
            return BadRequest("Employee Not found");
        }

        // POST api/<ValuesController>
        [HttpPost]
        [Route("new")]
        public async Task<IActionResult> Post([FromBody] EmployeeResource  resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("invalid input data");
            }
            var employee = _mapper.Map<EmployeeResource,Employee>(resource);
           var result = await _employeeService.addEmployee(employee);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Employee);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Employee employee)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Invalid input data");
            }
            employee.Id= id;    
            var result = await _employeeService.Update(id, employee);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Employee);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _employeeService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return Ok("Deleted Successfully");
        }
    }
}
