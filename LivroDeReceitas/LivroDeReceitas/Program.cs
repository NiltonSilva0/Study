class Program
{
    static void Main()
    {
        Console.Write(@"
█░░ █ █░█ █▀█ █▀█   █▀▄ █▀▀   █▀█ █▀▀ █▀▀ █▀▀ █ ▀█▀ ▄▀█ █▀
█▄▄ █ ▀▄▀ █▀▄ █▄█   █▄▀ ██▄   █▀▄ ██▄ █▄▄ ██▄ █ ░█░ █▀█ ▄█");
        LivroDeReceitas livro = new LivroDeReceitas();

        // Loop para interação contínua com o usuário
        while (true)
        {
            Console.WriteLine("\n\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar Receita");
            Console.WriteLine("2. Ver Todas as Receitas");
            Console.WriteLine("3. Atualizar Receita");
            Console.WriteLine("4. Excluir Receita");
            Console.WriteLine("5. Buscar Receita");
            Console.WriteLine("6. Sair");

            string opcao = Console.ReadLine();

            // Switch para lidar com a escolha do usuário
            switch (opcao)
            {
                case "1":
                    livro.AdicionarReceita();
                    break;

                case "2":
                    List<Receita> todasReceitas = livro.ObterTodasReceitas();
                    foreach (var receita in todasReceitas)
                    {
                        Console.WriteLine($"ID: {receita.Id}, Nome: {receita.Nome}, Instruções: {receita.Instrucoes}");
                    }
                    break;

                case "3":
                    Console.WriteLine("Digite o ID da receita que deseja atualizar:");
                    int idAtualizacao = int.Parse(Console.ReadLine());
                    livro.AtualizarReceita(idAtualizacao);
                    break;

                case "4":
                    Console.WriteLine("Digite o ID da receita que deseja excluir:");
                    int idExclusao = int.Parse(Console.ReadLine());
                    livro.ExcluirReceita(idExclusao);
                    break;

                case "5":
                    Console.WriteLine("Digite o termo de busca:");
                    string termoBusca = Console.ReadLine();
                    List<Receita> receitasEncontradas = livro.BuscarReceitasPorNome(termoBusca);

                    if (receitasEncontradas.Count > 0)
                    {
                        Console.WriteLine("Receitas encontradas:");
                        foreach (var receita in receitasEncontradas)
                        {
                            Console.WriteLine($"ID: {receita.Id}, Nome: {receita.Nome}, Instruções: {receita.Instrucoes}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma receita encontrada para o termo de busca.");
                    }
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
