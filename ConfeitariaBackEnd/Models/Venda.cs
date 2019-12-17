using System;
using System.ComponentModel.DataAnnotations;

namespace ConfeitariaBackEnd.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double preco { get; set; }
        public DateTime DataInclusao { get; set; }

        public DateTime DataAlteracao { get; set; }
        [Required]
        public Produto Produto { get; set; }
    }
}