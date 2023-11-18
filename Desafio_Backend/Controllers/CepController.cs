using Desafio_Backend.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Desafio_Backend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CepController:ControllerBase
    {
        private readonly ICepService _cepService;

        public CepController(ICepService cepService)
        {
            _cepService = cepService;
        }
        /// <summary>
        /// Busca o CEP passado no parâmetro
        /// </summary>
        /// <remarks>
        /// Faz a busca do cep informado e retorna os dados do cep correspondente e retorna os dados em formato JSON
        /// </remarks>
        /// <param name="cep"></param>
        /// <returns></returns>
        [HttpGet("buscar/{cep}")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> BuscarCep([FromRoute] string cep)
        {
            var response = await _cepService.BuscarEnderecoPorCep(cep);
            if(response.CodigoHttp== HttpStatusCode.OK)
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
