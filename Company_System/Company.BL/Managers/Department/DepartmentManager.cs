using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DAL;

namespace Company.BL
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IDepartmentRepo _departmentRepo;

        public DepartmentManager(IDepartmentRepo departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }
        public int Add(DepartmentAddDto departmentDto)
        {
            Department departmentToAdd = new Department
            {
                Name= departmentDto.Name,
                Budget= departmentDto.Budget,
            }; 
            _departmentRepo.Add(departmentToAdd);
            _departmentRepo.SaveChanges();
            return departmentToAdd.Id;
        }

        public bool Delete(int id)
        {
            Department? deptToDelete = _departmentRepo.GetByID(id);
            if (deptToDelete != null)
            {
                _departmentRepo.Delete(deptToDelete);
                _departmentRepo.SaveChanges();
                return true;
            }
            return false;
        }

        public List<DepartmentReadDto> GetAll()
        {
            var deptFromDB = _departmentRepo.GetAll();
            return deptFromDB.Select(d=> new DepartmentReadDto
            {
                Id = d.Id,
                Name = d.Name,
                Evaluation = d.Evaluation,
            }).ToList();
        }

        public DepartmentReadDto? GetById(int id)
        {
            var deptFromDB = _departmentRepo.GetByID(id);
            if (deptFromDB is null)
            {
                return null;
            }
            return new DepartmentReadDto
            {
                Id = deptFromDB.Id,
                Name = deptFromDB.Name,
                Evaluation = deptFromDB.Evaluation,
            };
        }

        public DepartmentWithEmployeeReadDto? GetDepartmentWithEmployee(int id)
        {
            var deptWithEmpFromDB = _departmentRepo.GetDepartmentByIdWithEmployees(id);
            if (deptWithEmpFromDB is null)
            {
                return null;
            }

            return new DepartmentWithEmployeeReadDto
            {
                Id = deptWithEmpFromDB.Id,
                Name = deptWithEmpFromDB.Name,
                Evaluation = deptWithEmpFromDB.Evaluation,

                Employees = deptWithEmpFromDB.Employees.Select(e => new EmployeeChildReadDto
                {
                    Id = e.Id,
                    Name = e.Name,
                }).ToList(),
            };
        }
    }
}
