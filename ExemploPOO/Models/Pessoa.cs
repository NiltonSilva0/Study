namespace ExemploPOO.Models
{
    internal class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() // VIRTUAL quer dizer que o método pode ser sobrescrito se a classe filha desejar.
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}
