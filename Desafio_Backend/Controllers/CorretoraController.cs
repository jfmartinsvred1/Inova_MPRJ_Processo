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
        /// <summary>
        /// Busca todas corretoras 
        /// </summary>
        /// <remarks>
        /// Busca todas corretoras listadas na CVM
        /// </remarks>
        /// <returns></returns>

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
        /// <summary>
        /// Busca uma corretora listada na CVM
        /// </summary>
        /// <remarks>
        /// Busca uma corretora pelo seu cnpj e retorna os dados em formato JSON
        /// </remarks>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        [HttpGet("buscar/{cnpj}")]
        public async Task<IActionResult> BuscarCorretora([FromRoute]string cnpj)
        {
            var response = await _corretoraService.BuscarCorretora(cnpj);
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
