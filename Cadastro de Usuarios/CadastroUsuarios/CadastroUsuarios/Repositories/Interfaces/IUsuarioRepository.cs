using CadastroUsuarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarios.Repositories
{
    public interface IUsuarioRepository
    {
        public List<Usuario> GetUsuarios();
        public bool AddUsuario(Usuario usuario, Endereco endereco);
        public Usuario GetUsuarioId(int usuarioId);
        public bool DeleteUsuario(int usuarioId);

        public bool UpdateUsuario(Usuario usuario, Endereco endereco);
    }
}
