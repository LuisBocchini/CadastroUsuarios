using CadastroUsuarios.Models;
using CadastroUsuarios.Repositories;
using CadastroUsuarios.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarios.Controllers
{
    public class CadastroUsuariosController : Controller
    {
        private readonly IUsuarioRepository UsuarioRepository;

        public CadastroUsuariosController(IUsuarioRepository usuarioRepository)
        {
            UsuarioRepository = usuarioRepository;
        }
        public IActionResult Index(int usuarioId, bool editar)
        {
            //Se for vizualizar
            if (usuarioId != 0 && editar == false)
            {
                Usuario usuario = UsuarioRepository.GetUsuarioId(usuarioId);
                ViewBag.usuario = usuario;
                ViewBag.editar = editar;
            }
            //Se for editar
            else if (usuarioId != 0 && editar == true)
            {
                Usuario usuario = UsuarioRepository.GetUsuarioId(usuarioId);
                ViewBag.usuario = usuario;
                ViewBag.editar = editar;
            }
            return View();
        }

        [HttpPost]
        public bool SalvarUsuario(UsuarioRequest usuario)
        {
            try
            {
                Usuario user = new Usuario()
                {
                    Id = usuario.Id,
                    Nome = usuario.Nome,
                    Email = usuario.Email,
                    CPF = usuario.CPF,
                    DataNascimento = usuario.DataNascimento,
                };

                Endereco endereco = new Endereco()
                {
                    Cep = usuario.Cep,
                    Logradouro = usuario.Logradouro,
                    Complemento = usuario.Complemento,
                    Bairro = usuario.Bairro,
                    Cidade = usuario.Cidade,
                    Estado = usuario.Estado,
                    UsuarioId = usuario.Id,
                    Id = usuario.EnderecoId
                };
                if (usuario.Id != 0)
                {
                    UsuarioRepository.UpdateUsuario(user, endereco);
                }
                else
                {
                    UsuarioRepository.AddUsuario(user, endereco);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }
    }
}
