namespace ApiCrud.Estudantes
{
    public class Estudante
    {
        public Guid Id { get; init; }
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }

        public Estudante(string nome)
        {
            Nome = nome;
            Id = Guid.NewGuid();
            Ativo = true;
        }

        public void atualizarNome(string nome)
        {
            Nome = nome;
        }
        public void desativar()
        {
            Ativo = false;
        }

    }
}
