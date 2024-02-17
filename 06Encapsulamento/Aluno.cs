namespace _06Encapsulamento
{
    public class Aluno
    {
        //Atributos/Proprietades
        private double nota1 { get; set; }
        private double nota2 { get; set; }

        //Métodos
        private double media()
        {
            return (nota1+nota2) / 2;
        }

        //Mensagem
        public void Mensagem() //Usei esse métodos para poder mostrar a média em outro lugar já que é private.
        {
            Console.WriteLine("Informe a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A média é: " + media());
        }
    }
}
