using Desafio_Backend.Interfaces;
using Desafio_Backend.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Desafio_Backend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FeriadoController:ControllerBase
    {
        private readonly IFeriadoService _feriadoService;

        public FeriadoController(IFeriadoService feriadoService)
        {
            _feriadoService = feriadoService;
        }
        /// <summary>
        /// Busca todos fériados
        /// </summary>
        /// <remarks>
        /// Busca todos fériados no ano passado no parametro e retorna os dados em formato JSON
        /// </remarks>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        [HttpGet("buscar/{ano}")]
        public async Task<IActionResult> BuscarFeriados([FromRoute] string ano)
        {
            var response = await _feriadoService.BuscarTodosFeriados(ano);
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
