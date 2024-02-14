using ApiCrud2.Context;
using ApiCrud2.Model;
using ApiCrud2.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrud2.Controllers
{
    [Route("api/v1/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add([FromForm]EmployeeViewModel employeeView)
        {
            // Verifica se o nome já existe no banco de dados
            if (_employeeRepository.Exists(employeeView.Name))
            {
                return Conflict("Employee with the same name already exists.");
            }
            else if (employeeView.Age <= 0)
            {
                return Conflict("The age can`t be 0 or less.");
            }else if (_employeeRepository.Exists(employeeView.Email))
            {
                return Conflict("Employee with the same email already exists.");
            }

            var filePath = Path.Combine("Storage", employeeView.Photo.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                employeeView.Photo.CopyTo(stream);
            }
            var employee = new Employee(Guid.NewGuid(), employeeView.Name, employeeView.Age, employeeView.Email, filePath);
            _employeeRepository.Add(employee);
            return Ok();

        }

        [Authorize]
        [HttpPost]
        [Route("{id}/Download")]
        public IActionResult Download(Guid id)
        {
            var employee = _employeeRepository.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            var dataBytes = System.IO.File.ReadAllBytes(employee.Photo);
            return File(dataBytes, "image/png");
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employeeRepository.GetAll());
        }

        [Authorize]
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromForm] EmployeeViewModel employeeView)
        {
            var employeeDb = _employeeRepository.GetById(employeeView.Id);
            if (employeeDb == null)
            {
                return NotFound();
            }
            _employeeRepository.Update(employeeDb);
            
            return Ok();
           
        }
        
            


    }
}
