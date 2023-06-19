using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BL
{
    public class DepartmentReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Evaluation { get; set; } = string.Empty;
    }
}
