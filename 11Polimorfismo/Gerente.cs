namespace _11Polimorfismo
{
    public class Gerente : Imposto
    {
        public override void ValeAlimentacao(double salario)//Subscreve o método de imposto
        {
            Console.WriteLine($"Desconto gerente do vale alimentação {(salario * 0.15).ToString("c")}");
        }
    }
}
