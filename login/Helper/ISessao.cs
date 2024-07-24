using login.Models;

namespace login.Helper
{
    public interface ISessao
    {
        void CriarSessausuario(UsuarioModel usuario);

        void RemoverSessaoUsuario();

        UsuarioModel BuscarSessaoDoUsuario();
    }
}
