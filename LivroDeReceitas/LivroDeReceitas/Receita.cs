// Models/Receita.cs
public class Receita
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Instrucoes { get; set; }

    public Receita(int id, string nome, string instrucoes)
    {
        Id = id;
        Nome = nome;
        Instrucoes = instrucoes;
    }
}
