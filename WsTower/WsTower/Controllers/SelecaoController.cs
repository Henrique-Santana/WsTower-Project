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
    public class SelecaoController : ControllerBase
    {
        SelecaoRepository selecaoRepository = new SelecaoRepository();


        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(selecaoRepository.Listar());
        }
    }
}