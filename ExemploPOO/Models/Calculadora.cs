using ExemploPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Calculadora : Icalculadora//IMPLEMENTANDO a interface Icalculadora, precisa colocar todos os métodos pra funcionar.
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //DIVIDIR ficou opcional pois o método na interface tem corpo de código.
    }
}
