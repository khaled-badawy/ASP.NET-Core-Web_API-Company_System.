using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.DAL
{
    public class DepartmentRepo : GenericRepo<Department>, IDepartmentRepo
    {
        private readonly CompanyContext _context;

        public DepartmentRepo(CompanyContext context) :base(context)
        {
            _context = context;
        }
        public Department? GetDepartmentByIdWithEmployees(int id)
        {
            return _context.Set<Department>().Include(d=>d.Employees).FirstOrDefault(i=>i.Id == id);
        }
    }

}

