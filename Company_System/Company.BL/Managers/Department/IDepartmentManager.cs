using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BL
{
    public interface IDepartmentManager
    {
        List<DepartmentReadDto> GetAll();
        DepartmentReadDto? GetById(int id);
        int Add(DepartmentAddDto departmentDto);
        bool Delete(int id);
        DepartmentWithEmployeeReadDto? GetDepartmentWithEmployee(int id);
    }
}
