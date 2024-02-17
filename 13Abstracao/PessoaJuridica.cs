namespace _13Abstracao
{
    public class PessoaJuridica : Padrao
    {
        public override void TaxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de empréstimo para pessoa jurídica: {(valor * 0.2).ToString("c")}");
        }
    }
}
