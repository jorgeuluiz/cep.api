using CepApi.Dto;
using CepApi.Services;
using System.Text.Json;


public class CepService : ICepService
{
    private static readonly Dictionary<string, CepResponseDto> _cache = [];
    private readonly HttpClient _httpClient;

    public CepService(HttpClient httpClient) => _httpClient = httpClient;
    

    public async Task<CepResponseDto> GetCepDataAsync(string cep)
    {       
        if (_cache.TryGetValue(cep, out CepResponseDto? value))        
            return value;        

        var response = await _httpClient.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
        var cepData = JsonSerializer.Deserialize<CepResponseDto>(response);

        if (cepData != null && cepData.IsValid())        
            _cache[cep] = cepData;        

        return cepData!;
    }
}
