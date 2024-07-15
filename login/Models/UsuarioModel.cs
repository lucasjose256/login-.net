using login.Enum;
using System.ComponentModel.DataAnnotations;

namespace login.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Digite seu nomde de usuário")]
        public string Nome { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public PerfilEnum Perfil { get; set; }

        public string Senha {  get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }


    }
}
