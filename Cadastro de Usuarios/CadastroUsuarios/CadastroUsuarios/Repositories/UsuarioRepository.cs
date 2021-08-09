using CadastroUsuarios.Context;
using CadastroUsuarios.Models;
using CadastroUsuarios.Requests;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarios.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly AppDbContext context;

        public UsuarioRepository(AppDbContext contexto)
        {
            context = contexto;
        }

        public List<Usuario> GetUsuarios()
        {
            IEnumerable<Usuario> usuarios = context.Usuarios;
            List<Usuario> lstUsuarios = usuarios.ToList();
            return lstUsuarios;
        }

        public Usuario GetUsuarioId(int usuarioId)
        {
            Usuario usuario = context.Usuarios.Where(x => x.Id == usuarioId).FirstOrDefault();
            Endereco endereco = context.Enderecos.Where(x => x.UsuarioId == usuarioId).FirstOrDefault();
            if (endereco != null)
            {
                usuario.Endereco = endereco;
            }

            return usuario;
        }

        public bool AddUsuario(Usuario usuario, Endereco endereco)
        {
            using IDbContextTransaction transaction = context.Database.BeginTransaction();
            {
                try
                {
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();
                    endereco.UsuarioId = usuario.Id;
                    context.Enderecos.Add(endereco);
                    context.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }

            }       
        }

        public bool UpdateUsuario(Usuario usuario, Endereco endereco)
        {
            using IDbContextTransaction transaction = context.Database.BeginTransaction();
            {
                try
                {
                    context.Usuarios.Update(usuario);
                    context.Enderecos.Update(endereco);
                    context.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }

            }
        }

        public bool DeleteUsuario(int usuarioId)
        {
            using IDbContextTransaction transaction = context.Database.BeginTransaction();
            {
                try
                {
                    Usuario usuario = context.Usuarios.Where(x => x.Id == usuarioId).FirstOrDefault();
                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }

            }
        }
    }
}
