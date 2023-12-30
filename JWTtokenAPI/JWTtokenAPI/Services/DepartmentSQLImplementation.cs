using JWTtokenAPI.Interfaces;
using JWTtokenAPI.Models;

namespace JWTtokenAPI.Services
{
    public class DepartmentSQLImplementation : IDepartment
    {

        private readonly DepartmentContext _departmentContext;

        public DepartmentSQLImplementation(DepartmentContext departmentContext)
        {
            _departmentContext = departmentContext;
        }



        public List<Department> AddDepartment(Department department)
        {
            _departmentContext.Add(department);
            _departmentContext.SaveChanges();
            var data = _departmentContext.Departments.ToList();
            return data;
        }

        public List<Department> GetAllDepartments()
        {
            var data = _departmentContext.Departments.ToList();
            return data;
        }

        public Department GetDepartmentById(int id)
        {
            var data = _departmentContext.Departments.ToList().Where(e => e.Id == id).FirstOrDefault();
            return data;
        }

        public List<Department> RemoveDepartment(int id)
        {
            Department data = _departmentContext.Departments.ToList().Where(e => e.Id == id).FirstOrDefault();
            _departmentContext.Remove(data);
            _departmentContext.SaveChanges();
            var datalist = _departmentContext.Departments.ToList();
            return datalist;
        }
    }
}