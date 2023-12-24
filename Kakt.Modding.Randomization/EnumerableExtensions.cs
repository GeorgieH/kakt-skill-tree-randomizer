namespace Kakt.Modding.Randomization;

public static class EnumerableExtensions
{
    public static T Random<T>(this IEnumerable<T> source, Random random)
    {
        return source.ElementAt(random.Next(source.Count()));
    }
}
