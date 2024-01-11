//GETTERS E SETTERS

//public class Carro
//{
//    private string _modelo; //campo privado


//    Se precisar de lógica faz assim:

//    public string Modelo
//    {
//        get { return _modelo; }
//        set { _modelo = value; }

//    }

//    Se náo precisar de lógica faz assim => public string Modelo { get; set; }
//    propriedade
//}

//----------------------------------------------------------------

//ARRAYS E LISTAS

//int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//Console.WriteLine($"Número de elementos {numeros.Length}");

//for(int i = 0; i <= numeros.Length; i++)
//{
//    Console.WriteLine(i);
//}

//int indiceArray = numeros[3];
//Console.WriteLine($"O índice 3 do array é: { indiceArray }");
//numeros[0] = 0;
//numeros[1] = 1;
//numeros[2] = 2;
//numeros[3] = 3;
//numeros[4] = 4;

//foreach (int i in numeros)
//{
//    Console.WriteLine(i);
//}

//----------------------------------------------------------------
//EXERCÍCIO


class Program
{
    static void Main()
    {
        Console.Write("Quantos números você deseja inserir no array? ");
        int tamanhoArray;

        // Certifica-se de que o usuário fornece um valor inteiro válido
        while (!int.TryParse(Console.ReadLine(), out tamanhoArray) || tamanhoArray <= 0)
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo.");
            Console.Write("Quantos números você deseja inserir no array? ");
        }

        int[] meuArray = new int[tamanhoArray];

        // Preenche o array com os valores fornecidos pelo usuário
        for (int i = 0; i < tamanhoArray; i++)
        {
            Console.Write($"Insira o número {i + 1}: ");

            // Certifica-se de que o usuário fornece um valor inteiro válido
            while (!int.TryParse(Console.ReadLine(), out meuArray[i]))
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
                Console.Write($"Insira o número {i + 1}: ");
            }
        }

        // Chama a função para somar os valores no array
        int soma = SomarArray(meuArray);

        // Exibe o resultado
        Console.WriteLine("A soma dos valores no array é: " + soma);
    }

    static int SomarArray(int[] array)
    {
        int soma = 0;

        // Loop através do array e soma os valores
        foreach (int valor in array)
        {
            soma += valor;
        }

        return soma;
    }
}

//----------------------------------------------------------------
//LISTA



//class Program
//{
//    static void Main()
//    {
//        // Criar uma lista de inteiros
//        List<int> numeros = new List<int>();

//        // Adicionar elementos à lista
//        numeros.Add(10);
//        numeros.Add(20);
//        numeros.Add(30);

//        // Imprimir a lista
//        Console.WriteLine("Lista original:");
//        ImprimirLista(numeros);

//        // Verificar se a lista contém um elemento específico
//        bool contemElemento = numeros.Contains(20);
//        Console.WriteLine($"A lista contém o elemento 20? {contemElemento}");

//        // Encontrar índice de um elemento na lista
//        int indiceElemento = numeros.IndexOf(20);
//        Console.WriteLine($"O índice do elemento 20 é: {indiceElemento}");

//        // Remover um elemento da lista
//        numeros.Remove(20);
//        Console.WriteLine("Lista após remover o elemento 20:");
//        ImprimirLista(numeros);

//        // Inserir elemento em uma posição específica
//        numeros.Insert(1, 25);
//        Console.WriteLine("Lista após inserir o elemento 25 no índice 1:");
//        ImprimirLista(numeros);

//        // Ordenar a lista
//        numeros.Sort();
//        Console.WriteLine("Lista ordenada:");
//        ImprimirLista(numeros);

//        // Inverter a ordem dos elementos na lista
//        numeros.Reverse();
//        Console.WriteLine("Lista invertida:");
//        ImprimirLista(numeros);

//        // Limpar todos os elementos da lista
//        numeros.Clear();
//        Console.WriteLine("Lista após limpar todos os elementos:");
//        ImprimirLista(numeros);
//    }

//    static void ImprimirLista(List<int> lista)
//    {
//        foreach (var elemento in lista)
//        {
//            Console.Write(elemento + " ");
//        }
//        Console.WriteLine();
//    }
//}



