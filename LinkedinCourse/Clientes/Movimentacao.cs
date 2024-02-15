namespace LinkedinCourse.Clientes
{
    internal class Movimentacao
    {
        public string Tipo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }

        public Movimentacao(string tipo, decimal valor)
        {
            Tipo = tipo;
            Valor = valor;
            Data = DateTime.Now;
        }
    }
}
