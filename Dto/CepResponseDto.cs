using System.Text.Json.Serialization;

namespace CepApi.Dto;

public class CepResponseDto
{
    [JsonPropertyName("cep")]
    public string Cep { get; set; } = string.Empty;

    [JsonPropertyName("logradouro")]
    public string Logradouro { get; set; } = string.Empty;

    [JsonPropertyName("complemento")]
    public string Complemento { get; set; } = string.Empty;

    [JsonPropertyName("bairro")]
    public string Bairro { get; set; } = string.Empty;

    [JsonPropertyName("localidade")]
    public string Localidade { get; set; } = string.Empty;

    [JsonPropertyName("uf")]
    public string Uf { get; set; } = string.Empty;

    [JsonPropertyName("ibge")]
    public string Ibge { get; set; } = string.Empty;

    [JsonPropertyName("gia")]
    public string Gia { get; set; } = string.Empty;

    [JsonPropertyName("ddd")]
    public string Ddd { get; set; } = string.Empty;

    [JsonPropertyName("siafi")]
    public string Siafi { get; set; } = string.Empty;

    public bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(Logradouro) ||
               !string.IsNullOrWhiteSpace(Bairro) ||
               !string.IsNullOrWhiteSpace(Cep) ||
               !string.IsNullOrWhiteSpace(Complemento) ||
               !string.IsNullOrWhiteSpace(Localidade) ||
               !string.IsNullOrWhiteSpace(Uf) ||
               !string.IsNullOrWhiteSpace(Ibge) ||
               !string.IsNullOrWhiteSpace(Gia) ||
               !string.IsNullOrWhiteSpace(Ddd) ||
               !string.IsNullOrWhiteSpace(Siafi);
    }
}
