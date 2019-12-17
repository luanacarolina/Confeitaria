using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConfeitariaBackEnd.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }    
        [Required]
        [StringLength(50)]
        public string Email { get; set; }   
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }    
        public string Endereço { get; set; }
        public int Cep { get; set; }    
        [StringLength(50)]
        public string Cidade { get; set; }
        public int Numero { get; set; }
        [StringLength(100)]
        public string Complemento { get; set; }

        public ICollection<Venda> Vendas { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}