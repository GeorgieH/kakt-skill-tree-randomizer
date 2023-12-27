namespace Kakt.Modding.Core;

public static class EnumExtensions
{
    public static IEnumerable<T> GetFlags<T>(this T input) where T : struct, Enum
    {
        foreach (T value in Enum.GetValues<T>())
        {
            if (Convert.ToInt32(value) != 0 && input.HasFlag(value))
            {
                yield return value;
            }
        }
    }
}
