using Kakt.Modding.Core.KnightsTale.Randomization;
using System.Text.Json;

namespace Kakt.Modding.Cli.KnightsTale;

public class RandomizationConfigurationService : IRandomizationConfigurationService
{
    private RandomizationConfiguration? randomizationConfiguration;

    private readonly IFileSystemService fileSystemService;

    public RandomizationConfigurationService(IFileSystemService fileSystemService)
    {
        this.fileSystemService = fileSystemService;
    }

    public RandomizationConfiguration Get()
    {
        if (randomizationConfiguration is null)
        {
            var json = fileSystemService.GetFileText(fileSystemService.RandomizationConfigurationPath);
            randomizationConfiguration = JsonSerializer.Deserialize<RandomizationConfiguration>(json)!;
        }

        return randomizationConfiguration;
    }
}
