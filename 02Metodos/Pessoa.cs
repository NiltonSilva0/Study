namespace _02Metodos
{
    public class Pessoa
    {
        //Método01
        public void Apresentar()
        {
            Console.WriteLine("Olá!");
        }

        //Método02
        public void Apresentar(string nome)
        {
            Console.WriteLine($"Olá, {nome}." );
        }

        //Método03
        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine($"Olá, {nome} você tem {idade} anos.");
        }
    }
}
