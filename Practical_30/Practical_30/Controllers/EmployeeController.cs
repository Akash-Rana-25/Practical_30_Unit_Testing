using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practical_30.Modal;
using Practical_30.Repositories;

namespace Practical_30.Controllers
{

    public class EmployeeController : Controller
    {
        [ApiController]
        [Route("api/employees")]
        public class EmployeesController : ControllerBase
        {
            private readonly IEmployeeRepositorie _employeeRepository;
            public EmployeesController(IEmployeeRepositorie employeeRepository)
            {
                _employeeRepository = employeeRepository;
            }

            [HttpGet]
            public IActionResult Get()
            {
                var items = _employeeRepository.GetAll();
                return Ok(items);
            }

            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var item = _employeeRepository.GetById(id);
                if (item is null)
                {
                    return NotFound();
                }
                return Ok(item);
            }

            [HttpPost]
            public IActionResult Post([FromBody] Employee employee)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var item = _employeeRepository.Add(employee);
                return CreatedAtAction("Get", new { id = item.Id }, item);
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var existingEmployee = _employeeRepository.GetById(id);
                if (existingEmployee == null)
                {
                    return NotFound();
                }
                _employeeRepository.Remove(existingEmployee);
                return NoContent();
            }
        }
    }

}
