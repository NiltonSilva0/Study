using Fundamentos_c_.Models;


////Datas
//DateTime dataAtual = DateTime.Now.AddDays(5);
//Console.WriteLine(dataAtual.ToString("dd/MM/yyy HH:mm"));

////Instanciando a classe pessoa

//Pessoa pessoa = new Pessoa();

//pessoa.Nome = "Marta";
//pessoa.Idade = 28;
//pessoa.Apresentar();

//--------------------------------------------------------
//SWITCH CASE

//Console.WriteLine("Digite uma letra? ");

//string letraDigitada = Console.ReadLine().ToLower();

//switch (letraDigitada)
//{
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":

//        Console.WriteLine($"A letra {letraDigitada} é uma vogal!!");
//        break;
//    default:
//        Console.WriteLine($"A letra {letraDigitada} não é uma vogal!!");
//        break;
//}

//-----------------------------------------------------------------------------
//OPERADORES LÓGICOS

Console.WriteLine("Quantos anos vc tem? ");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vc tem autorização dos seus pais S/N?");
string autorizacao = Console.ReadLine().ToLower();

if (autorizacao == "s" || autorizacao == "sim")
{
    Console.WriteLine("Vc tem autorização.");
}
else if (autorizacao == "n" || autorizacao == "não" || autorizacao == "nao")
{
    Console.WriteLine("Vc não tem autorização.");
}
else
{
    Console.WriteLine("Não é válido escreva sim ou não."); 
    Pergunta();
}

//switch (autorizacao)
//{
//    case "s":
//    case "sim":
//        Console.WriteLine("Vc tem autorização.");
//        break;
//    case "n":
//    case "não":
//    case "nao":
//        Console.WriteLine("Vc não tem autorização.");
//        break;
//    default:
//        Console.WriteLine("Não é válido escreva sim ou não.");
//        Pergunta();
//        break;
//}
void Pergunta()
{
    Console.WriteLine("Vc tem autorização dos seus pais S/N?");
    string autorizacao = Console.ReadLine().ToLower();

    if (autorizacao == "s" || autorizacao == "sim")
    {
        Console.WriteLine("Vc tem autorização.");
    }
    else if (autorizacao == "n" || autorizacao == "não" || autorizacao == "nao")
    {
        Console.WriteLine("Vc não tem autorização.");
    }
    else
    {
        Console.WriteLine("Não é válido escreva sim ou não.");
        Pergunta();
    }

}



