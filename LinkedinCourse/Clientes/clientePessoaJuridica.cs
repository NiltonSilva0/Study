namespace LinkedinCourse.Clientes
{
    internal class clientePessoaJuridica : Cliente
    {
        public clientePessoaJuridica(string codigo, string nome) : base(codigo, nome)
        {
            
        }

        public override decimal DescontarTaxa(decimal valor)
        {
            return valor - 2;
        }
    }
}
