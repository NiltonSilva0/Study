namespace _07Construtor
{
    public class Pessoa
    {
        //Construtor
        public Pessoa()
        {
            Console.WriteLine("Construtor executado!");
        }
        public Pessoa(string nome)
        {
            Console.WriteLine($"Ola {nome}");
        }
    }
}
