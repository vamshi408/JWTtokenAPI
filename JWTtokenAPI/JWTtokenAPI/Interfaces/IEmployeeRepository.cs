using JWTtokenAPI.Models;

namespace JWTtokenAPI.Interfaces
{
    public interface IEmployeeRepository
    {
        List<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployeeById(int id);
        List<EmployeeModel> AddEmployee(EmployeeModel employee);
        List<EmployeeModel> RemoveEmployee(int id);
    }
}
