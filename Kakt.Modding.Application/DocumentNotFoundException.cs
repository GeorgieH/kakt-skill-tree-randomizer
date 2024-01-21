namespace Kakt.Modding.Application;

public class DocumentNotFoundException(string path) : Exception
{
    public string Path { get; } = path;
}
