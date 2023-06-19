using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL
{
    public class EmployeeRepo :GenericRepo<Employee> , IEmployeeRepo
    {
        private readonly CompanyContext context;
        public EmployeeRepo(CompanyContext context):base(context)
        {
            this.context = context;
        }
    }
}
