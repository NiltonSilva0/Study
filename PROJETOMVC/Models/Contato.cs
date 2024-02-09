using System.ComponentModel.DataAnnotations;

namespace PROJETOMVC.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [RegularExpression("^[a-zA-ZÀ-ÿ\\s]+$", ErrorMessage = "O campo Nome deve conter apenas letras.")]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}

