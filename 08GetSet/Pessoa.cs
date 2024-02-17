namespace _08GetSet
{
    public class Pessoa
    {

        //Atributo/Propriedades
        private string Nome { get; set; }

        public Pessoa(string _nome)
        {
            Nome = _nome;
        }

        public string getNome()//Método público criado para trabalhar atributo privado
        {
            return Nome;
        }


    }
}
