using JWTtokenAPI.Interfaces;
using JWTtokenAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTtokenAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var data = _employeeRepository.GetAllEmployees();
            return Ok(data);
        }

        [HttpGet("GetEmployeeByID")]
        public IActionResult GetEmployeeByID(int id)
        {
            var data = _employeeRepository.GetEmployeeById(id);
            return Ok(data);
        }


        [HttpGet("RemoveEmployeeByID")]
        public IActionResult RemoveEmployeeByID(int id)
        {
            var data = _employeeRepository.RemoveEmployee(id);
            return Ok(data);
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(EmployeeModel employee)
        {
            var data = _employeeRepository.AddEmployee(employee);
            return Ok(data);
        }
    }
}