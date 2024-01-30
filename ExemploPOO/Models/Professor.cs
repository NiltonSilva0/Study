using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        public Professor(string nome, int idade) : base(nome, idade)
        {
            
        }
        public double Salario { get; set; }

        public override void Apresentar()//Aqui estamos sobrescrevendo o método Apresentar usando OVERRIDE.
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos, e sou um professor meu salário é: {Salario:C}");
        }
    }
}
