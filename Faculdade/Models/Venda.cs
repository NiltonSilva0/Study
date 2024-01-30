using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Faculdade.Models
{
    internal class Venda
    {
        public Venda(int id, string produto, decimal preco)
        {
            Id = id;
            //[JsonProperty("Nome_Produto")] Atributo passado para alterar algum nome de acordo com o recebido no arquivo Json.
            Produto = produto;
            Preco = preco;
        }
        public int Id { get; set; }
        public string Produto { get; set; }

        public decimal? Preco { get; set; }//PROPRIEDADES também podem ser nulas.
    }
}
