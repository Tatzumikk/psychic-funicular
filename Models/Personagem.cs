using System.ComponentModel.DataAnnotations;

namespace Xablau.Models
{
    public class Personagem
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MaxLength(50, ErrorMessage = "São suportados apenas 50 chars.")]
        public string Nome { get; set; }
        public string Tipo { get; set; }
    }
}