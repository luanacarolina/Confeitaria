using System;
using System.ComponentModel.DataAnnotations;

namespace ConfeitariaBackEnd.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public double preco { get; set; }
        [Required]
        public DateTime Validade { get; set; }
        [Required]
        public Usuario Confeiteiro { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}