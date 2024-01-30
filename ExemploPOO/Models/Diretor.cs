using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Diretor : Professor
    {
        public override void Apresentar()//Aqui estamos sobrescrevendo o método Apresentar usando OVERRIDE.
        {
            Console.WriteLine($"Diretor");
        }
    }
}
