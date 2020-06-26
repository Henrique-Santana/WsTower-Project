using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WsTower.Contexts;
using WsTower.Domains;
using WsTower.ViewModels;

namespace WsTower.Repositories
{
    public class UsuarioRepository
    {
        public List<Usuario> Listar()
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                return ctx.Usuario.ToList();
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                ctx.Usuario.Add(usuario);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                Usuario UsuarioId = ctx.Usuario.Find(id);
                ctx.Usuario.Remove(UsuarioId);
                ctx.SaveChanges();
            }
        }

        public Usuario BuscarPorId(int id)
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                return ctx.Usuario.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                Usuario usuarioBuscado = ctx.Usuario.Find(id);

                if (usuarioBuscado != null) { 

                    if (usuarioAtualizado.Nome != null) { 

                        usuarioBuscado.Nome = usuarioAtualizado.Nome;
                    }

                    if (usuarioAtualizado.Email != null)
                    {
                        usuarioBuscado.Email = usuarioAtualizado.Email;
                    }

                    if(usuarioAtualizado.Apelido != null)
                    {
                        usuarioBuscado.Apelido = usuarioAtualizado.Apelido;
                    }

                    if (usuarioAtualizado.Foto != null)
                    {
                        usuarioBuscado.Foto = usuarioAtualizado.Foto;
                    }

                    if (usuarioAtualizado.Senha != null)
                    {
                        usuarioBuscado.Senha = usuarioAtualizado.Senha;
                    }

                    ctx.Usuario.Update(usuarioBuscado);

                    ctx.SaveChanges();
                }
            }
        }

        public void AtualizarSenha (int id, Usuario usuarioAtualizado)
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                Usuario usuarioBuscado = ctx.Usuario.Find(id);

                if (usuarioBuscado != null)
                {
                    if (usuarioAtualizado.Senha != null)
                    {
                        usuarioBuscado.Senha = usuarioAtualizado.Senha;
                    }

                    ctx.Usuario.Update(usuarioBuscado);

                    ctx.SaveChanges();
                }

            }    

        }

        public Usuario BuscarPorEmailSenha(LoginViewModel loginViewModel)
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                return ctx.Usuario.FirstOrDefault(x => x.Email == loginViewModel.Email && x.Senha == loginViewModel.Senha);

            }
        }
    }
}
