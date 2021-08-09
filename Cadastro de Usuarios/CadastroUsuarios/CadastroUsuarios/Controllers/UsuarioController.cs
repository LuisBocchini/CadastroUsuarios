using CadastroUsuarios.Models;
using CadastroUsuarios.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarios.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository UsuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            UsuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            List<Usuario> usuarios = UsuarioRepository.GetUsuarios();
            ViewBag.usuarios = usuarios;
            return View();
        }

        [HttpDelete]
        public bool ExcluirUsuario(int usuarioId)
        {
            try
            {
                bool delete = UsuarioRepository.DeleteUsuario(usuarioId);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
           
        }

    }
}
