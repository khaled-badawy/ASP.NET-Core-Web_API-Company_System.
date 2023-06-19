using Company.BL;
using Microsoft.AspNetCore.Mvc;


namespace Comany_System.APIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentManager _departmentManager;

        public DepartmentController(IDepartmentManager departmentManager)
        {
            _departmentManager = departmentManager;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public ActionResult<List<DepartmentReadDto>> GetAll()
        {
            return _departmentManager.GetAll();
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public ActionResult<DepartmentReadDto> GetByID(int id)
        {
            DepartmentReadDto? dept = _departmentManager.GetById(id);
            if (dept == null)
            {
                return NotFound();
            }
            return dept;
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public void Add(DepartmentAddDto deptToAdd)
        {
            _departmentManager.Add(deptToAdd);
        }

        // PUT api/<DepartmentController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           bool isFound =  _departmentManager.Delete(id);
            if (isFound)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpGet]
        [Route("WithEmployees/{id}")]
        public ActionResult<DepartmentWithEmployeeReadDto> GetByIdWithEmployees(int id)
        {
            DepartmentWithEmployeeReadDto? dept = _departmentManager.GetDepartmentWithEmployee(id);

            if (dept is null)
            {
                return NotFound();
            }
            return dept;
        }
    }
}
