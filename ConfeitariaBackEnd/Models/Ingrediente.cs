using System;
using System.ComponentModel.DataAnnotations;

namespace ConfeitariaBackEnd.Models
{
    public class Ingrediente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
       
        public string Descricao { get; set; }  
        [Required] 
        public int Quantidade { get; set; }
        [Required]
        public DateTime Validade { get; set; }   

        public DateTime DataInclusao { get; set; }

        public DateTime DataAlteracao { get; set; } 

    }
}