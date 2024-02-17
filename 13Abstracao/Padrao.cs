namespace _13Abstracao
{
    public abstract class Padrao
    {
        //Método Obrigatório para classe que herda
        public abstract void TaxaEmprestimo(double valor);//A implementação é feita na classe que herda

        //Método Opcional para classe que herda
        public void CalcularPoupanca(double valor, double taxa)
        {
            Console.WriteLine($"Ganhos obtidos pela poupança: {valor*taxa}");
        }
    }
}
