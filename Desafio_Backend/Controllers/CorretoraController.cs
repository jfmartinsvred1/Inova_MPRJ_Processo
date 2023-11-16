using Desafio_Backend.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Desafio_Backend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CorretoraController:ControllerBase
    {
        private readonly ICorretoraService _corretoraService;

        public CorretoraController(ICorretoraService corretoraService)
        {
            _corretoraService = corretoraService;
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarCorretoras()
        {
            var response = await _corretoraService.BuscarTodasCorretoras();
            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErrorRetorno);
            }
        }
    }
}
