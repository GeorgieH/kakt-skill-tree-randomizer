namespace Kakt.Modding.Application.Randomization;

public interface IRandomNumberGeneratorService
{
    Random GetRandom();
}

public class RandomNumberGeneratorService : IRandomNumberGeneratorService
{
    private static readonly Random random = new();

    public Random GetRandom() => random;
}
