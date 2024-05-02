namespace JornadaMilhas.API.Helpers.ObtemRespotaGemini;

public interface IObtemRespostaGeminiService
{
    //Task<ObtemRespostaGeminiResponse> GetResponseGemini(string text);
    Task<object?> GetResponseGemini(string text);
}
