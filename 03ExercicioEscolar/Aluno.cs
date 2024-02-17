namespace _03ExercicioEscolar
{
    public class Aluno
    {
        //Atributos/Proprietades
        public string nome { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }

        //MÉTODOS

        //Média
        public double Media()
        {
            return (nota1 + nota2) / 2;
        }
        //Situação
        public string Situacao()
        {
            return Media() >= 7 ? "Aprovado" : "Reprovado";
        }
        //Mensagem
        public void Mensagem()
        {
            //Obter Média
            double obterMedia = Media();

            //Obter Situação
            string obterSituacao = Situacao();

            //Mensagem
            if (obterMedia >= 7)
            {
                Console.WriteLine($"{nome} está {obterSituacao} com média {obterMedia}.");
            }
            else
            {
                Console.WriteLine($"{nome} está {obterSituacao} com média {obterMedia}.");
            }

        }
    }
}
