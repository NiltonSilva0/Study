namespace ApiCrud2.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        bool Exists(string name);
        IEnumerable<Employee> GetAll();
        Employee? GetById(Guid id);
        object GetById(object id);
        void Update(Employee employeeDb);
    }
}
