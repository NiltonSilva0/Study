namespace _05Acesso
{
    public class Produto
    {
        //public Atributos e métodos visiveis em qualquer classe
        //private Atributos e métodos visiveis apenas na classe onde são criados
        //protected Atributos e métodos visiveis em classes onde são criados ou herdados

        public string nome { get; set; }
        private double valor {  get; set; }
    }
}
