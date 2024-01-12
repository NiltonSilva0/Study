List<string> listaDeTarefas = new List<string>();

while (true)
{
    Console.WriteLine(@"A̲p̲l̲i̲c̲a̲t̲i̲v̲o̲ d̲e̲ L̲i̲s̲t̲a̲ d̲e̲ T̲a̲r̲e̲f̲a̲s̲");
    Console.WriteLine("");
    Console.WriteLine("1. Adicionar Tarefa");
    Console.WriteLine("2. Exibir Tarefa");
    Console.WriteLine("3. Marcar Tarefa Concluida");
    Console.WriteLine("4. Remover Tarefa");
    Console.WriteLine("5. Sair");

    Console.WriteLine("Digite a opção: ");
    string escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            Console.WriteLine("Digite a nova tarefa: ");
            string novaTarefa = Console.ReadLine();
            listaDeTarefas.Add(novaTarefa);
            break;

        case "2":
            Console.WriteLine("Lista de Tarefas: ");
            int numeroTarefa = 1;
            foreach (string tarefa in listaDeTarefas)
            {
                Console.WriteLine($"{numeroTarefa}. {tarefa}");
                numeroTarefa++;
            }
            break;

        case "3":
            Console.WriteLine("Digite o número da tarefa concluída: ");
            int numeroTarefaConcluida = Convert.ToInt32(Console.ReadLine()) - 1;

            if (numeroTarefaConcluida >= 0 && numeroTarefaConcluida < listaDeTarefas.Count)
            {
                Console.WriteLine($"Tarefa '{listaDeTarefas[numeroTarefaConcluida]}' concluída!");
                // Adiciona código para marcar a tarefa como concluída.
                listaDeTarefas.RemoveAt(numeroTarefaConcluida);
            }
            else
            {
                Console.WriteLine("Número da tarefa inválido.");
            }
            break;

        case "4":
            Console.Write("Digite o número da tarefa a ser removida: ");
            int numeroTarefaRemover = Convert.ToInt32(Console.ReadLine()) - 1;

            if (numeroTarefaRemover >= 0 && numeroTarefaRemover < listaDeTarefas.Count)
            {
                Console.WriteLine($"Tarefa '{listaDeTarefas[numeroTarefaRemover]}' removida.");
                listaDeTarefas.RemoveAt(numeroTarefaRemover);
            }
            else
            {
                Console.WriteLine("Número de tarefa inválido.");
            }
            break;
        case "5":
            Console.WriteLine("Saindo do aplicativo. Até logo!");
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
        }
    Console.WriteLine(); // Adiciona uma linha em branco para melhor legibilidade

}


