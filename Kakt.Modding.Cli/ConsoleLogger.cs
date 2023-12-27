using Kakt.Modding.Randomization;

namespace Kakt.Modding.Cli;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
