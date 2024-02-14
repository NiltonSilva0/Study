
namespace ApiCrud2.ViewModel
{
    public class EmployeeViewModel
    {
        public Guid Id { get; internal set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
