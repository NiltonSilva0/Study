using ApiCrud2.Model;

namespace ApiCrud2.Context
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context = new EmployeeContext();

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public bool Exists(string name)
        {
            return _context.Employees.Any(e => e.Name == name);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee? GetById(Guid id)
        {
            return _context.Employees.Find(id);
        }

        public object GetById(object id)
        {
            return _context.Employees.Find(id);
        }

        public Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Employee> Update(Employee employeeDb)
        {
            return _context.Update(employeeDb);
        }

        void IEmployeeRepository.Update(Employee employeeDb)
        {
            _context.Update(employeeDb);
            _context.SaveChanges();
        }
    }
}
