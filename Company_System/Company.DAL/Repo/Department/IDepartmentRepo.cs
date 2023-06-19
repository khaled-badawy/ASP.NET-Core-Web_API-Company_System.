using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DAL;

namespace Company.DAL
{
    public interface IDepartmentRepo : IGenericRepo<Department>
    {
        public Department? GetDepartmentByIdWithEmployees(int id);
    }
}
