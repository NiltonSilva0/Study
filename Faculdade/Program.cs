//using Faculdade.Models;
//using Newtonsoft.Json;//PACOTE externo instalado para serializar objetos.

//TIPOS NULOS
//bool? desejaReceberEmail = null;

//if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)//SEMPRE que for verificar um valor nulo use o hasvalue para saber se tem algum valor na variavel.
//{
//    Console.WriteLine("O usuário deseja receber emails.");
//}
//else
//{
//    Console.WriteLine("O usuário não respondeu ou não deseja receber emails.");
//}

////DESERIALIZAÇÃO lê um arquivo externo que vem em formato json e transforma em objeto.

//string conteudoArquivo = File.ReadAllText("Arquivos/vendas.jason");

//List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

//foreach (Venda venda in listaVenda)
//{
//    Console.WriteLine(venda.Id);
//    Console.WriteLine(venda.Produto);
//    Console.WriteLine(venda.Preco);
//}


////SERIALIZAÇÃO
//List<Venda> listaVendas = new List<Venda>();

//Venda v1 = new Venda(1, "Material de escritório", 25.00M);
//Venda v2 = new Venda(2, "Licença de Software", 110.00M);

//listaVendas.Add(v1);
//listaVendas.Add(v2);

//string serializado = JsonConvert.SerializeObject(listaVendas);

//File.WriteAllText("Arquivos/vendas.json", serializado);//Cria um arquivo com o conteudo da lista serializada.

//Console.WriteLine(serializado);




//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //COMANDO usado para setar a região no código, formando a moeda e tudo mais para o lugar escolhido.

//Aluno aluno1 = new Aluno(nome: "Nilton Silva", sexo: "Masculino", idade: 39);
//Aluno aluno2 = new Aluno(nome: "Karla Carvalho", sexo: "Feminino", idade: 28);
//Aluno aluno3 = new Aluno(nome: "Luiz Silva", sexo: "Masculino", idade: 37);

//Curso medicina = new Curso(nome: "Medicina", valor: 7800.00M);

//medicina.AlunosList = new List<Aluno>();

//medicina.AdicionarAluno(aluno2);
//medicina.ListarAlunos();

//Curso sistemas = new Curso(nome: "Sistemas de Informação", valor: 978.50M);//DECIMAL precisa do M no final pra ser representado.

//sistemas.AlunosList = new List<Aluno>();

//sistemas.AdicionarAluno(aluno1);
//sistemas.AdicionarAluno(aluno3);
//sistemas.ListarAlunos();

//------------------------------------------------------------------------------
////FORMATAÇÕES
//double porcentagem = .3422;
//Console.WriteLine(porcentagem.ToString("P"));
//int numero = 123123;
//Console.WriteLine(numero.ToString("##-##-##"));
//DateTime data = DateTime.Now;
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//DateTime data = DateTime.Now;
//Console.WriteLine(data.ToShortDateString());

//------------------------------------------------------------------------------
//EXCEÇÕES E COLEÇÕES
//try
//{
//    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//    foreach (string linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }

//}
//catch (FileNotFoundException ex)
//{
//    Console.WriteLine($"Exceção específica - Arquivo não encontrado {ex.Message}");
//}
//catch (DirectoryNotFoundException ex)
//{
//    Console.WriteLine($"Exceção específica - Diretório não encontrado {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Exceção geneérica {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("FIM");//O bloco finally sempre é executado independente de ter exepction ou não.
//}
//--------------------------------------------------------------------------------
//THROW
//new exception().Metodo1();
//--------------------------------------------------------------------------------
//FILA/QUEUE - FIFO first in first out
//Queue<int> fila = new Queue<int>();

//fila.Enqueue(2);
//fila.Enqueue(5);
//fila.Enqueue(12);
//fila.Enqueue(8);

//foreach (int i in fila)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");//Sempre remove o primeiro elemento da lista.
//fila.Enqueue(20);//Adiciona um elemento na fila, porém ele entra em último lugar na fila.

//foreach (int i in fila)
//{
//    Console.WriteLine(i);
//}
//----------------------------------------------------------------------------------
//PILHA/STACK - LIFO last in first out
//Stack<int> pilha = new Stack<int>();

//pilha.Push(2);//Inclui um item na pilha
//pilha.Push(9);
//pilha.Push(11);
//pilha.Push(3);

//foreach (int i in pilha)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");//pop remove um item da pilha, sempre o último item inserido.
//pilha.Push(20);

//foreach (int i in pilha)
//{
//    Console.WriteLine(i);
//}
//----------------------------------------------------------------------------------
//DICTIONARY lista valores de forma única usando uma chave
//Dictionary <string, string> estados = new Dictionary<string, string>();

//estados.Add("AC", "Acre");
//estados.Add("MG", "Minas Gerais");
//estados.Add("SP", "São Paulo");
//estados.Add("RJ", "Rio de Janeiro");

//Console.WriteLine(estados["AC"]);//Mostra o valor que está contido na chave.

//foreach (var item in estados)
//{
//    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
//}

//Console.WriteLine("----------------------------");

//estados.Remove("AC");//Remove o item pela chave dele, que é única.
//estados["MG"] = "Minas Gerais - Valor alterado";//Atera o valor pela chave.

//foreach (var item in estados)
//{
//    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
//}
//string chave = "MG2";//Testando a existencia de um item no dictionary.
//Console.WriteLine($"Verificando elemento: {chave}");

//if (estados.ContainsKey(chave))
//{
//    Console.WriteLine($"Elemento encontrado: {chave}");
//}
//else
//{
//    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
//}
//----------------------------------------------------------------
//TUPLAS/TUPLES As tuplas no C# são uma estrutura de dados do tipo de referência que podem armazenar valores de diferentes tipos.

//(int Id, string Nome, string Sobrenome) tupla = (1, "Nilton", "Silva");
//Console.WriteLine($"Nome: {tupla.Nome}");

//RetornaTupla arquivo = new RetornaTupla();//RETORNA TUPLA ATRAVÉS DE UM MÉTODO.

//var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");// SINTAXE para receber o retorno das 3 informações.
////Aqui temos o retorno de 3 tipos diferentes bool, string[] e int. O _ é o descarte caso não precise usar a info retornada.
//if (sucesso)
//{
//    //Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeDeLinhas}");
//    foreach (string linha in linhasArquivo)
//    {
//        Console.WriteLine(linha);
//    }
//}
//else
//{
//    Console.WriteLine("Não foi possivel ler o arquivo");
//}
//IF TERNÁRIO
//int numero = 20;
//bool ehPar = false;

//if (numero % 2 == 0)
//{
//    Console.WriteLine($"O número {numero} é par");
//}
//else
//{
//    Console.WriteLine($"O número {numero} é impar");
//}

//ehPar = numero % 2 == 0;
//Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));