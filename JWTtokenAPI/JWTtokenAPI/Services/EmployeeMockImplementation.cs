using JWTtokenAPI.Interfaces;
using JWTtokenAPI.Models;

namespace JWTtokenAPI.Services
{
    public class EmployeelMockImplementation : IEmployeeRepository
    {
        public static List<EmployeeModel> EmployeeModelEntity;
        public EmployeelMockImplementation()
        {
            EmployeeModelEntity = new List<EmployeeModel>();
            EmployeeModelEntity.Add(
                new EmployeeModel() { EmployeeId = 1001, EmployeeName = "Vamshi", EmployeeEmail = "vamshi@gmail.com", EmployeePhone = "1234567890" });
            EmployeeModelEntity.Add(
                new EmployeeModel() { EmployeeId = 1002, EmployeeName = "Krishna", EmployeeEmail = "Krishna@gmail.com", EmployeePhone = "1234567890" });
            EmployeeModelEntity.Add(
                new EmployeeModel() { EmployeeId = 1003, EmployeeName = "Bandi", EmployeeEmail = "Bandi@gmail.com", EmployeePhone = "1234567890" });
        }
        public List<EmployeeModel> AddEmployee(EmployeeModel EmployeeModel)
        {
            EmployeeModelEntity.Add(EmployeeModel);
            return EmployeeModelEntity;
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            return EmployeeModelEntity;
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            var data = EmployeeModelEntity.Where(e => e.EmployeeId == id).FirstOrDefault();
            return data;
        }

        public List<EmployeeModel> RemoveEmployee(int id)
        {
            var data = EmployeeModelEntity.Where(e => e.EmployeeId == id).FirstOrDefault();
            return EmployeeModelEntity;
        }
    }
}