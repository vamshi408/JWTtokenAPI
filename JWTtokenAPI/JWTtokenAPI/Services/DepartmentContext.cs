using JWTtokenAPI.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JWTtokenAPI.Services
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext(DbContextOptions<DepartmentContext> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
    }
}