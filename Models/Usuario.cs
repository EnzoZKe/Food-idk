using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAAAA_FUNCIONA_MDS.Models
{
    [Table("Usuario")]
    public class Usuario
    {

        [Key]

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome do usuário")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Login é obrigatório")]
        [Display(Name = "Login do usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        [Display(Name = "Senha do usuário")]
        public string Senha { get; set; }

        [Display(Name = "Imagem do usuário")]
        public string? FotoPFP { get; set; }
        public int UsuarioId { get; set; }

    }
}