namespace _11Polimorfismo
{
    public class Imposto
    {
        public virtual void ValeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto padrão do vale alimentação {(salario * 0.1).ToString("c")}");
        }

        public void ValeTransporte(double salario)
        {
            Console.WriteLine($"Desconto padrão do vale transporte {(salario * 0.06).ToString("c")}");//ToString "c" formata na moeda local
        }
    }
}
