namespace JornadaMilhas.API.Helpers.ObtemRespotaGemini;

public class ObtemRespostaGeminiResponse
{
    public Candidate[] Candidates { get; set; }

    public override string ToString()
    {
        return Candidates.First()
                .Content
                .Parts.First()
                .Text;
    }
}
