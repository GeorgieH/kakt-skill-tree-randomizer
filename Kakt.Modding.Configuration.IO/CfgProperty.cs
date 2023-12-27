using System.Text.RegularExpressions;

namespace Kakt.Modding.Configuration.IO;

public partial class CfgProperty : CfgElement
{
    private static readonly Regex Regex = GetRegex();

    public CfgProperty(string key, string value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public string Value { get; }

    public static bool TryParse(string line, out CfgProperty property)
    {
        property = null!;

        var matches = Regex.Matches(line);

        if (matches.Count == 1)
        {
            var match = matches[0];
            var key = match.Groups["key"].Value;
            var value = match.Groups["value"].Value;
            property = new CfgProperty(key, value);

            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return $"{Key}={Value}";
    }

    [GeneratedRegex("(?<key>.*)=(?<value>.*)")]
    private static partial Regex GetRegex();
}
