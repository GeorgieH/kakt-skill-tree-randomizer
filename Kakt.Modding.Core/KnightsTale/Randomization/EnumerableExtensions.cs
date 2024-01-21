namespace Kakt.Modding.Core.KnightsTale.Randomization;

public static class EnumerableExtensions
{
    public static T Random<T>(this IEnumerable<T> source, Random random)
    {
        var count = source.Count();
        var index = random.Next(count);

        return source.ElementAt(index);
    }

    // https://stackoverflow.com/questions/273313/randomize-a-listt
    public static void Shuffle<T>(this IList<T> list, Random random)
    {
        var n = list.Count;

        while (n > 1)
        {
            n--;
            var k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
