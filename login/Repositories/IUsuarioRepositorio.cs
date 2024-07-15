using login.Models;

namespace login.Repositories
{
    public interface IUsuarioRepositorio
    {

        List<UsuarioModel> BuscarTodos();

       UsuarioModel BuscarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);

        bool Apagar(int id);
    }
}
