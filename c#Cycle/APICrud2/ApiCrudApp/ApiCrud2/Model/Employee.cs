namespace ApiCrud2.Model
{
    public class Employee
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }
        public string Photo { get; private set; }

        public Employee(Guid id, string name, int age, string email, string photo)
        {
            Id = id;
            Name = name;
            Age = age;
            Email = email;
            Photo = photo;
        }

        public Employee()
        {
        }
    }
}
