using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canil.Models
{
    internal class Cachorro
    {
        //CONSTRUTOR VAZIO PARA PASSAR OS VALORES DEPOIS
        public Cachorro()
        {
            
        }
        public Cachorro(string nome, string raca, int idade, string cor)//CONSTRUTOR com parametros pegando as propriedades para fazer uso dos parametros.
        {
            Nome = nome;
            Raca = raca;
            Idade = idade;
            Cor = cor;
        }
        private string _nome;
        private string _raca;
        private int _idade;
        private string _cor;

        public string Nome //PROPRIEDADES
        {  
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            } 
        }
        public string Raca
        {
            get => _raca.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("A raça não pode ser vazio.");
                }
                _raca = value;
            }
        }
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero.");
                }
                _idade = value;
            }
        }
        public string Cor
        {
            get => _cor;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("A cor não pode ser vazia.");
                }
                _cor = value;
            }
        }

    }
}
