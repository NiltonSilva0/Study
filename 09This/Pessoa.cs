namespace _09This
{
    public class Pessoa
    {
        //Atributo
        private string Nome = "Carlos";

        //Construtor
        public Pessoa(string Nome)
        {
            Console.WriteLine(Nome);
            Console.WriteLine(this.Nome); //Se refere ao nome dentro da classe o atributo interno
        }

    }
}
