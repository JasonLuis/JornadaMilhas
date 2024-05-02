using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

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
           throw new Exception("Error calling Gemini API", ex);
        }
    }
}
