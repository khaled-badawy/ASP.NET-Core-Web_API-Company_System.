using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DAL;

namespace Company.DAL
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Budget { get; set; }
        public string Evaluation { get; set; } = string.Empty;
        public ICollection<Employee> Employees { get;set; } = new HashSet<Employee>();
    }
}
