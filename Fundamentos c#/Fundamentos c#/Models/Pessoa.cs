﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Fundamentos_c_.Models
{
    internal class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} eu tenho {Idade} anos de idade.");

        }

    }

}

