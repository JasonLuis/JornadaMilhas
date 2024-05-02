namespace JornadaMilhas.API.Helpers.ObtemRespotaGemini;


public class ObtemRespostaGeminiRequest
{

    public Content[] Contents { get; set; } = [];

    public ObtemRespostaGeminiRequest(string text)
    {
        Contents =
            [
                new Content
                {
                    Parts = new[]
                    {
                        new Part
                        {
                            Text = text
                        }
                    }
                }
            ];
    }
}
