using Azure;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using OpenAI_API.Moderation;
using System.Net.Http;

namespace JornadaMilhas.API.Helpers.ObtemRespotaGemini;

internal class ObtemRespostaGeminiService(HttpClient httpClient) : IObtemRespostaGeminiService
{
    public async Task<object?> GetResponseGemini(string text)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        var apiKey = configuration.GetConnectionString("API_KEY");

        if (apiKey.IsNullOrEmpty())
        {
            throw new Exception("Error, apiKey is Empty");
        }

        var request = new ObtemRespostaGeminiRequest(text);

        try
        {
            var requestContent = new ObtemRespostaGeminiRequest(text);
            var context = await httpClient.PostAsJsonAsync($"?key={apiKey}", requestContent);

            context.EnsureSuccessStatusCode(); // Lança uma exceção
            
            var response = await context.Content.ReadAsStringAsync();
            var responseBody = JsonConvert.DeserializeObject<ObtemRespostaGeminiResponse>(response);

            return responseBody;
        }
        catch (HttpRequestException ex)
        {
            // Trate a exceção aqui
            throw new Exception("Error calling Gemini API", ex);
        }
    }
}
