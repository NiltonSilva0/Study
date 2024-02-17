namespace OOPCourse.Agentes
{
    internal class Aluno : Pessoa
    {
        private bool Ativo = true;
        private string Tipo { get; set; }

        public Aluno(bool _ativo, string _tipo)
        {
            Ativo = _ativo;
            Tipo = _tipo;

        }

        public override void Apresentar()
        {
            if (Ativo == true)
            {
            Console.WriteLine($"Ola meu nome é {nome} e tenho {idade} anos, estou estudando, logo sou um {Tipo}.");
            }else
            Console.WriteLine($"Ola meu nome é {nome} e tenho {idade} anos, não estou estudando, logo não sou um {Tipo}.");
        }
    }
}
