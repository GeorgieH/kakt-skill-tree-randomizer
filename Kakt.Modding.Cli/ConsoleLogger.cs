using Kakt.Modding.Application;

namespace Kakt.Modding.Cli;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
