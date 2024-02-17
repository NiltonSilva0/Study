namespace _10Heranca
{
    public class Pessoa
    {
        //Atributos/Propriedades
        protected string Nome { get; set; }//Protected pode ser acessado pelos filhos
        protected int Idade { get; set; }

        //Métodos
        protected void MensagemPessoa()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }

    }
}
