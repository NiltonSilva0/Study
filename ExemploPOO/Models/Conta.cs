namespace ExemploPOO.Models
{
    internal abstract class Conta
    {
        protected decimal saldo;//PROTECTED fica protegido contra alterações externas, porém as classes filhas podem alterar.

        public abstract void Creditar(decimal valor);//ABSTRACT não tem implementação e precisa ser implementado na classe que recebe a herança.
        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }

    }
}
