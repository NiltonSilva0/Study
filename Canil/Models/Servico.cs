using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canil.Models
{
    internal class Servico
    {
        public Servico()//CONSTRUTOR VAZIO caso não tenha a entrada pra colocar.
        {
            
        }
        public Servico(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public List<Cachorro> Cachorros { get; set; }

        public void AdicionarCachorro(Cachorro cachorro)//METODOS sempre fazem alguma coisa são ações da classe.
        {
            Cachorros.Add(cachorro);
        }
        public int QntDeCachorros()
        {
            int quantidade = Cachorros.Count;
            return quantidade;
        }
        public bool RemoverCachorro(Cachorro cachorro)
        {
            return Cachorros.Remove(cachorro);
        }
        public void ListarCachorro()
        {
            Console.WriteLine($"Cachorros para o serviço de {Nome}\n");
            foreach (Cachorro cachorro in Cachorros)
            {
                Console.WriteLine($"Nome: {cachorro.Nome}");
                Console.WriteLine($"Raça: {cachorro.Raca}");
                Console.WriteLine($"Idade: {cachorro.Idade} anos");
                Console.WriteLine($"Cor: {cachorro.Cor}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
