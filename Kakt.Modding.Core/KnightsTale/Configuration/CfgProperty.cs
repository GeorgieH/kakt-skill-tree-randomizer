using System.Text.RegularExpressions;

namespace Kakt.Modding.Core.KnightsTale.Configuration;

public partial class CfgProperty : CfgElement
{
    private static readonly Regex Regex = GetRegex();

    public CfgProperty(string name, object value)
    {
        Name = name;
        Value = value;
    }

    public override string Name { get; }
    public object Value { get; set; }

    public static bool TryParse(string line, out CfgProperty property)
    {
        property = null!;

        var l = line.Trim();
        var matches = Regex.Matches(l);

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

    public override string ToString(int indentationLevel)
    {
        return $"{GetIndentation(indentationLevel)}{Name}={Value}{Environment.NewLine}";
    }

    [GeneratedRegex("(?<key>.*)=(?<value>.*)")]
    private static partial Regex GetRegex();
}
