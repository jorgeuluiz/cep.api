using CepApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CepApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CepController : ControllerBase
{
    private readonly ICepService _cepService;

    public CepController(ICepService cepService) => _cepService = cepService;
    

    [HttpGet("{cep}")]
    public async Task<IActionResult> GetCepData(string cep)
    {        
        if (cep.Length != 8 || !int.TryParse(cep, out _))        
            return NotFound(new { message = "Por favor, insira um CEP válido." });        

        var cepData = await _cepService.GetCepDataAsync(cep);

        if (cepData == null || !cepData.IsValid())        
            return NotFound(new { message = "CEP não encontrado" });        

        return Ok(cepData);
    }
}

