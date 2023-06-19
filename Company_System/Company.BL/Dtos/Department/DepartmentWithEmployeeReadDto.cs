using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BL
{
    public class DepartmentWithEmployeeReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Evaluation { get; set; } = string.Empty;
        public List<EmployeeChildReadDto> Employees { get; set; } = new List<EmployeeChildReadDto>();
    }
}
