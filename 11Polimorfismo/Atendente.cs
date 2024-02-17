namespace _11Polimorfismo
{
    public class Atendente : Imposto
    {
        public override void ValeAlimentacao(double salario)//Subscreve o método de imposto
        {
            Console.WriteLine($"Desconto atendente do vale alimentação {(salario * 0.12).ToString("c")}");
        }
    }
}
