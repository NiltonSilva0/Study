using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Models
{
    internal class Aluno
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome, string sexo, int idade)
        {
            Nome = nome;
            Sexo = sexo;
            Idade = idade;
        }

        private string _nome;
        private string _sexo;
        private int _idade;

        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }
                _nome = value;
            } 
            
        }
        public string Sexo
        {
            get => _sexo.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Sexo não pode ser vazio");
                }
                _sexo = value;
            }

        }
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }

        }

    }
}
