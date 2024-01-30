using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno()//Adicionado esse construtor vazio eu tiro a obrigatoriedade de ter de colocar nome e idade ao instanciar a classe Aluno.
        {
            
        }
        public Aluno(string nome, int idade) : base(nome, idade)//CONSTRUTOR por herança.
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()//Aqui estamos sobrescrevendo o método Apresentar usando OVERRIDE.
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}
