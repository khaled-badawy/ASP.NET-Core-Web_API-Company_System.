using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DAL;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;

namespace Company.DAL
{
    public class Employee : IdentityUser
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
