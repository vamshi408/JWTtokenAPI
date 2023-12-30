using JWTtokenAPI.Models;

namespace JWTtokenAPI.Interfaces
{
    public interface IDepartment
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        List<Department> AddDepartment(Department department);
        List<Department> RemoveDepartment(int id);
    }
}
