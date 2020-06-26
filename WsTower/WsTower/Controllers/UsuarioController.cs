using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WsTower.Domains;
using WsTower.Repositories;
using WsTower.ViewModels;

namespace WsTower.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();

        [HttpGet]
        public IActionResult ListarTodos()
        {
            //return Ok(new { mensagem = "ok" });
            return Ok(usuarioRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Usuario usuario = usuarioRepository.BuscarPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                usuarioRepository.Cadastrar(usuario);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("{LoginViewModel}")]
        public IActionResult Login(LoginViewModel loginViewModel)
        {

            Usuario usuario = usuarioRepository.BuscarPorEmailSenha(loginViewModel);

            if (usuario == null)
            {
                return NotFound("Email ou Senha incorreto");
            }

            return Ok("Você Logou");
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            usuarioRepository.Deletar(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Usuario usuarioAtualizado)
        {
            try
            {
                Usuario usuarioBuscado = usuarioRepository.BuscarPorId(id);
                if (usuarioBuscado == null)
                {
                    return NotFound();
                }
                usuarioRepository.Atualizar(id, usuarioAtualizado);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}