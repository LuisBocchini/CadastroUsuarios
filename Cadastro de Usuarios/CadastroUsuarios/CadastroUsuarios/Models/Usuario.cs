using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [StringLength(11)]
        public string CPF { get; set; }
        [Required]

        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        public Endereco Endereco { get; set; }

    }
}
