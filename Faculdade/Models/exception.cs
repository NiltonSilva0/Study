using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Models
{
    public class exception
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception)//Pode ou não ter uma variável para receber a exceção.
            {
                Console.WriteLine("Exceção tratada");
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }
}
