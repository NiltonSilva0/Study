namespace _10Heranca
{
    public class Colaborador : Pessoa
    {
        private double Salario {  get; set; }//Pertence somente a essa classe

        public Colaborador(string nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;

            MensagemPessoa();
            MensagemColaborador();
        }

        private void MensagemColaborador()
        {
            Console.WriteLine($"Salário: {Salario}");
        }
    }
}
