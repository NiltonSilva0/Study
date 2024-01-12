// Services/LivroDeReceitas.cs
using System;
using System.Collections.Generic;

public class LivroDeReceitas
{
    private List<Receita> receitas;
    private int proximoId;

    public LivroDeReceitas()
    {
        receitas = new List<Receita>();
        proximoId = 1;
    }

    // Métodos AdicionarReceita, ObterTodasReceitas, EncontrarReceitaPorId,
    // AtualizarReceita e ExcluirReceita aqui...
    // Adiciona uma nova receita com entrada do usuário
    public void AdicionarReceita()
    {
        Console.WriteLine("Digite o nome da receita:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite as instruções da receita:");
        string instrucoes = Console.ReadLine();

        Receita novaReceita = new Receita(proximoId, nome, instrucoes);
        proximoId++;

        receitas.Add(novaReceita);
        Console.WriteLine("Receita adicionada com sucesso!");
    }

    // Retorna todas as receitas
    public List<Receita> ObterTodasReceitas()
    {
        return receitas;
    }

    // Encontra uma receita pelo ID
    public Receita EncontrarReceitaPorId(int id)
    {
        return receitas.Find(r => r.Id == id);
    }

    // Atualiza uma receita pelo ID
    public void AtualizarReceita(int id)
    {
        Receita receitaExistente = receitas.Find(r => r.Id == id);

        if (receitaExistente != null)
        {
            Console.WriteLine("Digite o novo nome da receita:");
            string novoNome = Console.ReadLine();

            Console.WriteLine("Digite as novas instruções da receita:");
            string novasInstrucoes = Console.ReadLine();

            receitaExistente.Nome = novoNome;
            receitaExistente.Instrucoes = novasInstrucoes;

            Console.WriteLine("Receita atualizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Receita não encontrada.");
        }
    }

    // Exclui uma receita pelo ID
    public void ExcluirReceita(int id)
    {
        Receita receitaExistente = receitas.Find(r => r.Id == id);

        if (receitaExistente != null)
        {
            receitas.Remove(receitaExistente);
            Console.WriteLine("Receita excluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Receita não encontrada.");
        }
    }
    public List<Receita> BuscarReceitasPorNome(string termoBusca)
    {
        // Utilizamos o método FindAll para buscar todas as receitas que contenham o termo de busca no nome
        return receitas.FindAll(r => r.Nome.Contains(termoBusca, StringComparison.OrdinalIgnoreCase));
    }
}

