namespace OOPCourse.Agentes
{
    internal class Professor : Pessoa
    {
        private bool Ativo = true;
        private string Tipo { get; set; }

        public Professor(bool _ativo, string _tipo)
        {
            Ativo = _ativo;
            Tipo = _tipo;

        }

        public override void Apresentar()
        {
            if (Ativo == true)
            {
                Console.WriteLine($"Ola meu nome é {nome} e tenho {idade} anos, estou trabalhando, e sou um {Tipo}.");
            }
            else
                Console.WriteLine($"Ola meu nome é {nome} e tenho {idade} anos, não estou trabalhando, logo não sou um {Tipo}.");
        }
    }
}
