namespace OOPCourse
{
    public class Pessoa
    {
        public string? nome { get; set; }
        public int idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {nome} e tenho {idade} anos.");
        }

    }
}
