Console.WriteLine(@"
█▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█   █▀▀ █▀█ █▄░█ █▀ █▀█ █░░ █▀▀
█▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█   █▄▄ █▄█ █░▀█ ▄█ █▄█ █▄▄ ██▄");

Console.WriteLine("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação desejada(+,-,*,/): ");
string operacao = Console.ReadLine();

Console.WriteLine("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

double resultado = 0;

switch (operacao)
{
    case "+": resultado = num1 + num2; break;
    case "-": resultado = num1 - num2; break;
    case "*": resultado = num1 * num2; break;
    case "/": 
        if(num2 != 0)
        {
            resultado = num1 / num2;
        }
        else
        {
            Console.WriteLine("Erro: Divisao por zero!");
            return;
        }
        break;
    default: Console.WriteLine("Operação invalida!"); break;
}

Console.WriteLine($"Resultado: {resultado}");

