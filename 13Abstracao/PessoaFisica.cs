namespace _13Abstracao
{
    public class PessoaFisica : Padrao
    {
        public override void TaxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de empréstimo para pessoa física: {(valor * 0.1).ToString("c")}");
        }
    }
}
