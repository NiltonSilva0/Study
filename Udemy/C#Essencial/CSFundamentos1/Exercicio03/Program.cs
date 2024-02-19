//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Primeiro Número: {num1}");
//Console.WriteLine($"Segundo Número: {num2}");
//Console.WriteLine($"Terceiro Número: {num3}");

//if (num1 > num2 && num1 > num3)
//{
//    Console.WriteLine($"O primeiro número {num1} é o maior");
//}
//else if (num2 > num1 && num2 > num3)
//{
//    Console.WriteLine($"O segundo número {num1} é o maior");
//}
//else
//{
//    Console.WriteLine($"O terceiro número {num1} é o maior");
//}

//int num = 0;
//int soma = 0;

//Console.WriteLine($"Os 10 primeiros números naturais são: ");
//for (int i = 0; i < 10; i++)
//{
//    Console.Write(num = i + 1);
//    soma += num;
//}
//Console.WriteLine("\n");
//Console.WriteLine($"A soma dos números é : {soma}");

//Console.WriteLine($"Os 10 primeiros números naturais são: ");
//while (num < 10)
//{
//    Console.Write(num = num + 1);
//    soma += num;
//}
//Console.WriteLine("\n");
//Console.WriteLine($"A soma dos números é : {soma}");

//Console.WriteLine($"Os 10 primeiros números naturais são: ");
//do
//{
//    Console.Write(num + 1);
//    soma += num + 1;
//    num++;
//} while (num < 10);

//Console.WriteLine("\n");
//Console.WriteLine($"A soma dos números é : {soma}");

//Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero recebido via teclado

//while (true) // Loop infinito até quebrar com a instrução 'break'
//{
//    Console.Write("Digite um número natural maior que zero (ou digite -1 para encerrar o programa): ");
//    int numero = Convert.ToInt32(Console.ReadLine());

//    if (numero <= 0)
//    {
//        if (numero == 0)
//        {
//            Console.WriteLine("O número precisa ser maior que zero. Tente novamente.");
//            continue; // Volta ao início do loop enquanto
//        }
//        else if(numero == -1)
//        {
//            Console.WriteLine("Programa encerrado.");
//            break; // Sai do loop enquanto
//        }

//    }

//    Console.WriteLine("Tabela de multiplicação para o número " + numero + ":");

//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine(numero + " x " + i + " = " + (numero * i));
//    }
//}

//bool continuar = true;

//while (continuar)
//{
//    Console.WriteLine("Qual a instrução para sair de um loop?");
//    Console.WriteLine("a. quit");
//    Console.WriteLine("b. continue");
//    Console.WriteLine("c. break");
//    Console.WriteLine("d. exit");
//    Console.WriteLine("Qual a opção correta? (Tecle x para sair)");

//    string resposta = Console.ReadLine();

//    if (resposta.ToLower() == "x")
//    {
//        continuar = false; // Altera a variável de controle para false para sair do loop
//        Console.WriteLine("Programa encerrado.");
//    }
//    else if (resposta.ToLower() == "c")
//    {
//        Console.WriteLine("Resposta correta!\n");
//    }
//    else
//    {
//        Console.WriteLine("Resposta incorreta. Tente novamente.\n");
//    }
//}

//for (int i = 10; i <= 20; i += 2)
//{
//    if (i == 16)
//        continue; // Pula o número 16
//    Console.WriteLine(i);
//}
//Console.WriteLine("Incrementando 1 em cada passo:");
//for (int i = 10; i <= 20; i++)
//{
//    if (i == 16)
//        continue; // Pula o número 16
//    if (i % 2 == 0)
//        Console.WriteLine(i);
//}
//Console.WriteLine("Loop infinito com break e continue:");
//int num = 10;
//while (true)
//{
//    if (num > 20)
//        break; // Sai do loop quando atinge 21
//    if (num == 16)
//    {
//        num++; // Incrementa num para evitar o número 16
//        continue; // Pula o número 16
//    }
//    Console.WriteLine(num);
//    num += 2; // Incrementa 2 em cada passo
//}

//for (int i = 1; i <= 4; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");

//    }
//    Console.WriteLine();
//}

//while (true)
//{

//    Console.WriteLine("Insira uma nota de 0 a 10: ");
//    int nota = Convert.ToInt32(Console.ReadLine());

//    switch (nota)
//    {
//        case 10:
//            if (nota == 10)
//            {
//                Console.WriteLine("A+");
//            }
//            break;
//        case 9:
//            if (nota == 9)
//            {
//                Console.WriteLine("A");
//            }
//            break;
//        case 7:
//        case 8:
//            if (nota == 7 || nota == 8)
//            {
//                Console.WriteLine("B");
//            }
//            break;
//        case 6:
//            if (nota == 6)
//            {
//                Console.WriteLine("C");
//            }
//            break;
//        case 5:
//            if (nota == 5)
//            {
//                Console.WriteLine("E");
//            }
//            break;
//        case 4:
//        case 3:
//        case 2:
//        case 1:
//        case 0:
//            if (nota < 5)
//            {
//                Console.WriteLine("F");
//            }
//            break;
//        default:
//            Console.WriteLine("Nota inválida!");
//            break;
//    }
//    Console.WriteLine(); // Adiciona uma linha em branco para melhorar a legibilidade

//    // Condição de saída do loop
//    Console.Write("Deseja avaliar outro aluno? (s/n): ");
//    string continuar = Console.ReadLine().ToLower();
//    if (continuar != "s")
//    {
//        Console.WriteLine("Programa encerrado.");
//        break;
//    }
//}

//while (true)
//{

//    Console.WriteLine("Insira um número inteiro: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Escolhar operação: (+, -, /, *)");
//    string operacao = Console.ReadLine();
//    Console.WriteLine("Insira outro número inteiro: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());

//    switch (operacao)
//    {
//        case "+":
//            {
//                Console.WriteLine($"{num1 + num2}");
//            }
//            break;
//        case "-":
//            {
//                Console.WriteLine($"{num1 - num2}");
//            }
//            break;
//        case "/":
//            {
//                if (num1 == 0 || num2 == 0)
//                {
//                    Console.WriteLine("Não existe divisão por zero.");
//                }
//                Console.WriteLine($"{num1 / (double)num2:F2}");
//            }
//            break;
//        case "*":
//            {
//                Console.WriteLine($"{num1 * num2}");
//            }
//            break;
//    }
//    Console.WriteLine(); // Adiciona uma linha em branco para melhorar a legibilidade
//    Console.WriteLine("Deseja fazer outra operação? S/N");
//    string resposta = Console.ReadLine().ToLower();
//    if (resposta != "s")
//    {
//        Console.WriteLine("Programa encerrado.");
//        break;
//    }

//}
