using System;
using System.Collections.Generic;
using LinkedinCourse.Clientes;

class Program
{
    static List<Cliente> clientes = new List<Cliente>();

    static void Main(string[] args)
    {
        ConsultarCliente();
    }

    static void ConsultarCliente()
    {
        Console.WriteLine("Olá! Bem vindo ao banco TT.");
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Cliente cliente = null;

        foreach (Cliente cli in clientes)
        {
            if (cli.Nome == nome)
            {
                cliente = cli;
            }
        }

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado! Deseja cadastrar? Digite S ou N");
            string resposta = Console.ReadLine();
            if (resposta == "S" || resposta == "s")
            {
                Console.WriteLine("Digite seu Codigo: ");
                string codigoClienteNovo = Console.ReadLine();
                Console.WriteLine("Digite seu Nome: ");
                string nomeClienteNovo = Console.ReadLine();
                Console.WriteLine("Digite o tipo de conta PF ou PJ: ");
                string tipoConta = Console.ReadLine();

                if (tipoConta == "PF" || tipoConta == "pf")
                {
                    cliente = new clientePessoaFisica(codigoClienteNovo, nomeClienteNovo);
                }
                else if (tipoConta == "PJ" || tipoConta == "pj")
                {
                    cliente = new clientePessoaJuridica(codigoClienteNovo, nomeClienteNovo);
                }

                clientes.Add(cliente);
                Console.WriteLine("Cliente cadastrado com sucesso!");
                ExibirMenu(cliente);
            }
        }
        else
        {
            ExibirMenu(cliente);
        }
    }

    static void ExibirMenu(Cliente cliente)
    {
        Console.WriteLine($"Olá {cliente.Nome}");
        Console.WriteLine("Digite a opção desejada: ");
        Console.WriteLine("1 - Extrato");
        Console.WriteLine("2 - Saque");
        Console.WriteLine("3 - Deposito");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Opção Extrato selecionada.");
                ExibirExtrato(cliente);
                break;
            case "2":
                Console.WriteLine("Opção Saque selecionada.");
                RealizarSaque(cliente);
                break;
            case "3":
                Console.WriteLine("Opção Depósito selecionada.");
                RealizarDeposito(cliente);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    static void RealizarSaque(Cliente cliente)
    {
        Console.WriteLine("Digite o valor do saque: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());
        cliente.RealizarSaque(valor);
        Console.WriteLine("Deseja realizar outra transação? Digite S ou N: ");
        string realizarOutraTransacao = Console.ReadLine();

        if (realizarOutraTransacao == "S" || realizarOutraTransacao == "s")
        {
            ExibirMenu(cliente);
        }
        Console.WriteLine("Foi um prazer atende-lo!");
    }

    static void RealizarDeposito(Cliente cliente)
    {
        Console.WriteLine("Digite o valor do depósito: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());
        cliente.RealizarDeposito(valor);
        Console.WriteLine("Deseja realizar outra transação? Digite S ou N: ");
        string realizarOutraTransacao = Console.ReadLine();

        if (realizarOutraTransacao == "S" || realizarOutraTransacao == "s")
        {
            ExibirMenu(cliente);
        }
        Console.WriteLine("Foi um prazer atende-lo!");
    }

    static void ExibirExtrato(Cliente cliente)
    {
        Console.WriteLine($"Extrato de {cliente.Nome}:");
        foreach (Movimentacao mov in cliente.movimentacoes)
        {
            Console.WriteLine($"Tipo: {mov.Tipo}, Valor: {mov.Valor}, Data: {mov.Data}");
        }

        Console.WriteLine("Deseja exibir o menu novamente? Digite S ou N: ");
        string resposta = Console.ReadLine();
        if (resposta == "S" || resposta == "s")
        {
            ExibirMenu(cliente);
        }
        else
        {
            Console.WriteLine("Deseja consultar outro cliente? Digite S ou N: ");
            string resposta2 = Console.ReadLine();
            if (resposta2 == "S" || resposta2 == "s")
            {
                ConsultarCliente();
            }
        }
    }


}
