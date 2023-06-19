using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DAL;
using Microsoft.EntityFrameworkCore;

namespace Company.DAL
{
    public class CompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public CompanyContext(DbContextOptions<CompanyContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seeding Employees

            var employees = new List<Employee>{
                new Employee
                {
                    Id= 1,
                    Name = "Khaled",
                    DepartmentId= 1,
                },
                new Employee
                {
                    Id= 2,
                    Name = "Mohamed",
                    DepartmentId= 1,
                },
                new Employee
                {
                    Id= 3,
                    Name = "Ali",
                    DepartmentId= 1,
                },
                new Employee
                {
                    Id= 4,
                    Name = "Ahmed",
                    DepartmentId= 2,
                },
                new Employee
                {
                    Id= 5,
                    Name = "Eslam",
                    DepartmentId= 2,
                },
                new Employee
                {
                    Id= 6,
                    Name = "Omar",
                    DepartmentId= 2,
                },

            };
            #endregion
            #region Departments

            var departments = new List<Department> 
            {
                new Department
                {
                    Id= 1,
                    Name = "Sales",
                    Budget = 5000,
                    Evaluation = "Good",
                },
                new Department
                {
                    Id= 2,
                    Name = "Marketing",
                    Budget = 10000,
                    Evaluation = "Moderate",
                }
            };
            #endregion

            modelBuilder.Entity<Employee>().HasData(employees);
            modelBuilder.Entity<Department>().HasData(departments);

        }
    }
}
