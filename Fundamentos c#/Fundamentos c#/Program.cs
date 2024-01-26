//using Fundamentos_c_.Models;

//////Datas
////DateTime dataAtual = DateTime.Now.AddDays(5);
////Console.WriteLine(dataAtual.ToString("dd/MM/yyy HH:mm"));

//////Instanciando a classe pessoa

////Pessoa pessoa = new Pessoa();

////pessoa.Nome = "Marta";
////pessoa.Idade = 28;
////pessoa.Apresentar();

////--------------------------------------------------------
////SWITCH CASE

////Console.WriteLine("Digite uma letra? ");

////string letraDigitada = Console.ReadLine().ToLower();

////switch (letraDigitada)
////{
////    case "a":
////    case "e":
////    case "i":
////    case "o":
////    case "u":

////        Console.WriteLine($"A letra {letraDigitada} é uma vogal!!");
////        break;
////    default:
////        Console.WriteLine($"A letra {letraDigitada} não é uma vogal!!");
////        break;
////}

////-----------------------------------------------------------------------------
////OPERADORES LÓGICOS

////Console.WriteLine("Quantos anos vc tem? ");
////int idade = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Vc tem autorização dos seus pais S/N?");
////string autorizacao = Console.ReadLine().ToLower();

////if (autorizacao == "s" || autorizacao == "sim" == idade >= 18)
////{
////    Console.WriteLine("Vc tem autorização.");
////}
////else if (autorizacao == "n" || autorizacao == "não" || autorizacao == "nao" || idade < 18)
////{
////    Console.WriteLine("Vc não tem autorização.");
////}
////else
////{
////    Console.WriteLine("Não é válido escreva sim ou não."); 
////    Pergunta();
////}

////switch (autorizacao)
////{
////    case "s":
////    case "sim":
////        Console.WriteLine("Vc tem autorização.");
////        break;
////    case "n":
////    case "não":
////    case "nao":
////        Console.WriteLine("Vc não tem autorização.");
////        break;
////    default:
////        Console.WriteLine("Não é válido escreva sim ou não.");
////        Pergunta();
////        break;
////}
////void Pergunta()
////{
////    Console.WriteLine("Vc tem autorização dos seus pais S/N?");
////    string autorizacao = Console.ReadLine().ToLower();

////    if (autorizacao == "s" || autorizacao == "sim")
////    {
////        Console.WriteLine("Vc tem autorização.");
////    }
////    else if (autorizacao == "n" || autorizacao == "não" || autorizacao == "nao")
////    {
////        Console.WriteLine("Vc não tem autorização.");
////    }
////    else
////    {
////        Console.WriteLine("Não é válido escreva sim ou não.");
////        Pergunta();
////    }

////}

////--------------------------------------------------------
////CALCULADORA COM CLASSE POTENCIA E TRIGONOMETRIA

//Calculadora calculadora = new Calculadora();

//Console.WriteLine("Digite um numero: ");
//double n1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite outro número: ");
//double n2 = Convert.ToDouble(Console.ReadLine());

//calculadora.Somar(n1, n2);
//Console.WriteLine(calculadora);
//calculadora.Subtrair(n1, n2);
//Console.WriteLine(calculadora);
//calculadora.Multiplicar(n1, n2);
//Console.WriteLine(calculadora);
//calculadora.Dividir(n1, n2);
//Console.WriteLine(calculadora);
//calculadora.Potencia(n1, n2);
//Console.WriteLine(calculadora);
//calculadora.RaizQuadrada(n1);
//Console.WriteLine(calculadora);
//calculadora.Seno(n1);
//Console.WriteLine(calculadora);
//calculadora.Coseno(n1);
//Console.WriteLine(calculadora);
//calculadora.Tangente(n1);
//Console.WriteLine(calculadora);

//----------------------------------------------------------------
//ESTRUTURAS DE REPETIÇÃO

//int numero = 5;

//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine($"{numero} x {i} = {numero * i}");
//}

//int numero = 5;
//int contador = 1;

//while (contador <= 10)
//{
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//    contador++;

//    if ( contador == 6 )
//    {
//        break; //Quebra o loop do laço for/while
//    }
//}

//int soma = 0;
//int numero;

//do
//{
//    Console.WriteLine("Digite os números que deseja somar ou zero pra sair: ");
//    numero = Convert.ToInt32(Console.ReadLine());
//    soma += numero;

//} while (numero != 0); // Executa uma vez antes de fazer as validações

//Console.WriteLine($"A soma total é: {soma}");

//string opcao; //Menu interativo com loop infinito até escolher sair.
//bool finalizar = true;

//while (finalizar) // Ao setar true aqui coloco em loop infinito, passando uma variável bool posso sair sem o uso do exit.
//{
//    Console.Clear();
//    Console.WriteLine("\nDigite a opção desejada: ");
//    Console.WriteLine("1 - Cadastrar Cliente");
//    Console.WriteLine("2 - Buscar Cliente");
//    Console.WriteLine("3 - Apagar Cliente");
//    Console.WriteLine("4 -  Enerrar");

//    opcao = Console.ReadLine();

//    switch (opcao)
//    {
//        case "1":
//            Console.WriteLine("Cadastro de Cliente");
//            break;
//        case "2":
//            Console.WriteLine("Busca");
//            break;
//        case "3":
//            Console.WriteLine("Delete");
//            break;
//        case "4":
//            Console.WriteLine("Encerrar"); // Ao digitar o 4 para sair quebra o loop e sai do programa.
//            finalizar = false;
//            //Environment.Exit(0);
//            break;
//        default:
//            Console.WriteLine("Opção invalida!");
//            break;
//    }
//Console.WriteLine("O programa se encerrou!!");
//}

////--------------------------------------------------------
//ARRAYS E LISTAS

//Podem ser declarados dos dois jeitos
//string[] array = new string[] { "Maça", "Laranja", "Melancia", "Tamarino" };
//string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril"};

////Precisa do contador usa o FOR
//Console.WriteLine("Percorrendo o array com o FOR");
//int[] arrayInteiros = new int[3];

//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;

////Redimensiona o tamanho do  array fazendo um cópia dele com os elementos do antigo
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//for (int i = 0; i < arrayInteiros.Length; i++)
//{
//    Console.WriteLine($"Posição N° {i} - {arrayInteiros[i]}");
//}

////Não precisa do contador usa o FOREACH, o contador aqui nesse caso foi só pra pegar o valor da posição
//Console.WriteLine("Percorrendo o array com o FOREACH");
//int contador = 0;
//foreach (int i in arrayInteiros)
//{
//    Console.WriteLine($"Posição N° {contador} - {i}");
//    contador++;
//}

//Listas não tem tamanho máximo ela se adapta a qualquer tamanho
//Console.WriteLine("Percorrendo a lista com o FOR");
//List<string> listaString = new List<string>();

//listaString.Add("Maçã");
//listaString.Add("Laranha");
//listaString.Add("Banana");

//for (int i = 0; i < listaString.Count; i++)
//{
//    Console.WriteLine($"Posição N° {i} - {listaString[i]}");
//}


//Console.WriteLine("Percorrendo a lista com o FOREACH");
//int contador = 0;

//foreach (string str in listaString)
//{
//    Console.WriteLine($"Posição N° {contador} - {str}");
//    contador++;
//}

//--------------------------------------------------------

//Comentário para discrever Classes e métodos
/// <summary>
/// 
/// </summary>






