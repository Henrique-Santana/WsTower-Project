using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WsTower.Domains;
using WsTower.Repositories;

namespace WsTower.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        JogadorRepository jogadorRepository = new JogadorRepository();

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(jogadorRepository.Listar());
        }


    }
}