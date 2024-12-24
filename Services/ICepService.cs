using CepApi.Dto;

namespace CepApi.Services;

public interface ICepService
{
    Task<CepResponseDto> GetCepDataAsync(string cep);
}
