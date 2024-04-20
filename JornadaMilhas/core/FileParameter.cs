namespace JornadaMilhas.API.core;

public class FileParameter
{
    public required string Name { get; init; }
    public required Stream Stream { get; init; }
    public required string ContentType { get; init; }
}
