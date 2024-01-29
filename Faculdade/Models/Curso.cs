using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Models
{
    internal class Curso
    {
        public Curso()
        {
            
        }
        public Curso(string nome, decimal valor)
        {
            NomeDoCurso = nome;
            ValorDoCurso = valor;
        }
        private string _nomeDoCurso;
        private decimal _valorDoCurso;
        public string NomeDoCurso 
        { 
            get => _nomeDoCurso.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("O nome do curso não pode ser vazio");
                }
                _nomeDoCurso = value;
            }
        }
        public decimal ValorDoCurso
        {
            get => _valorDoCurso;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("O valor do curso não pode ser zero");
                }
                _valorDoCurso = value;
            }
        }
        public List<Aluno> AlunosList { get; set; }

        public void AdicionarAluno(Aluno aluno)
        {
            AlunosList.Add(aluno);
        }
        public bool RemoverAluno(Aluno aluno)
        {
            return AlunosList.Remove(aluno);
        }
        public int QntDeAlunosMatriculados()
        {
            int quantidade = AlunosList.Count;
            return quantidade;
        }
        public void ListarAlunos()
        {
            //FOR  por conta de precisar do contador e no valor curso o :C formata a currency de acordo com as especificações do sistema.
            Console.WriteLine($"Alunos matriculados no curso de {NomeDoCurso} - Quantidade: {QntDeAlunosMatriculados()} - Valor: {ValorDoCurso:C}\n");
            for( int count = 0; count < AlunosList.Count; count++)
            {
                Console.WriteLine($"N° {count + 1}. {AlunosList[count].Nome}");
                Console.WriteLine($"Sexo: {AlunosList[count].Sexo}");
                Console.WriteLine($"Idade: {AlunosList[count].Idade} anos\n");
                Console.WriteLine("--------------------------");

            }   
   
        }
    }
}
