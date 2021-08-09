using System.ComponentModel.DataAnnotations;

namespace CadastroUsuarios.Models
{
    public class Endereco
    {
        [Required]
        public int Id { get; set; }
        [StringLength(8)]
        public string Cep { get; set; }
        [StringLength(50)]
        public string Logradouro { get; set; }
        [StringLength(50)]
        public string Complemento { get; set; }

        [StringLength(200)]
        public string Bairro { get; set; }
        [StringLength(200)]
        public string Cidade { get; set; }
        [StringLength(200)]
        public string Estado { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public Usuario Usuario { get; set; }

    }
}
