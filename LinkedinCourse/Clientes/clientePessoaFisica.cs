namespace LinkedinCourse.Clientes
{
    internal class clientePessoaFisica : Cliente
    {
        public clientePessoaFisica(string codigo, string nome) : base(codigo, nome)
        {

        }

        public override decimal DescontarTaxa(decimal valor)
        {
            return valor - 1;
        }
    }
}
