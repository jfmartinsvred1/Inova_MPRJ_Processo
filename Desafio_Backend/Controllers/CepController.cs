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
        [HttpGet("buscar/{cep}")]
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
