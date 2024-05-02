using JornadaMilhas.API.Helpers.ObtemRespotaGemini;

namespace JornadaMilhas.API.Helpers;

public class GerarTextoDescritivo
{
    private readonly IObtemRespostaGeminiService _obtemRespostaGeminiService;

    public GerarTextoDescritivo(IObtemRespostaGeminiService obtemRespostaGeminiService)
    {
        _obtemRespostaGeminiService = obtemRespostaGeminiService;
    }

    internal async Task<string> GerarTexto(string destino, int qtdCaracteres)
    {
        /*** Utilizando o ChatGPT ***/
        //var client = new OpenAIAPI("Key");

        //var chat = client.Chat.CreateConversation();
        //chat.AppendSystemMessage($"Faça um resumo sobre {destino} enfatizando o porque este lugar é incrível." +
        //    $" Utilize uma linguagem informal e até {qtdCaracteres} caracteres no máximo em cada parágrafo." +
        //    $" Crie 2 parágrafos neste resumo.");

        //var response = await chat.GetResponseFromChatbotAsync();
        /******/

        /*** Utilizando o Google_Generate_AI ***/
        // Documentação da biblioteca Google_Generate_AI: https://github.com/gunpal5/Google_GenerativeAI

        //var client = new GenerativeModel(apiKey!);
        //var chat = client.StartChat(new StartChatParams());
        //var response = await chat.SendMessageAsync(
        //    $"Faça um resumo sobre {destino} enfatizando o porque este lugar é incrível." +
        //    $" Utilize uma linguagem informal e até {qtdCaracteres.ToString()} caracteres no máximo em cada parágrafo." +
        //    $" Crie 2 parágrafos neste resumo."
        //);

        var message = $"Faça um resumo sobre {destino} enfatizando o porque este lugar é incrível." +
            $" Utilize uma linguagem informal e até {qtdCaracteres.ToString()} caracteres no máximo em cada parágrafo." +
            $" Crie 2 parágrafos neste resumo.";

       var response = await _obtemRespostaGeminiService.GetResponseGemini(message);

        return response!.ToString()!;
    }
}
  