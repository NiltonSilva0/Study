using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface Icalculadora//INTERFACE criação da interface com os métodos obrigatórios para quem for implementar/"herdar".
    {
        int Somar(int a, int b);
        int Subtrair(int a, int b);
        int Multiplicar(int a, int b);//MÉTODOS sem corpo são obrigatórios.
        int Dividir(int a, int b)//MÉTODOS com corpo são opcionais.
        {
            return a / b;
        }

    }
}
