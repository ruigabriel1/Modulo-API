using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Modulo_API.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObeterDataHoraAtuall")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortDateString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, bem vindo ao sistema!";
            return Ok(new { mensagem });
        }
    }
}
