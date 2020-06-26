using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WsTower.Repositories;

namespace WsTower.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        JogoRepository jogoRepository = new JogoRepository();

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(jogoRepository.Listar());
        }

        [HttpGet("PorData/{DataJogo}")]
        public IActionResult ListarPorData(string DataJogo)
        {
            return Ok(jogoRepository.ListarPoData(DataJogo));
        }

        [HttpGet("PorEstadio/{Estadio}")]
        public IActionResult ListarPorEstadio(string Estadio)
        {
            return Ok(jogoRepository.ListarPorEstadio(Estadio));
        }


        [HttpGet("PorSelecao/{Selecao}")]
        public IActionResult ListarPorSelecao(string Selecao)
        {
            jogoRepository.ListarPorSelecao(Selecao);

            if(Selecao != null)
            {
                return Ok(Selecao);
            }

            return BadRequest();
            
        }
    }
}