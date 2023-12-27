using System.Text;

namespace Kakt.Modding.Configuration.IO;

public class CfgObject : CfgElement
{
    public static readonly string StartToken = "{";
    public static readonly string EndToken = "}";

    public CfgObject(string name)
    {
        Name = name;
    }

    public List<CfgElement> Elements { get; } = [];
    public string Name { get; }

    public override string ToString(int indentationLevel)
    {
        var stringBuilder = new StringBuilder();

        var indentation = GetIndentation(indentationLevel);

        stringBuilder.AppendLine($"{indentation}{Name}");
        stringBuilder.AppendLine($"{indentation}{StartToken}");

        foreach (var element in Elements)
        {
            stringBuilder.Append(element.ToString(indentationLevel + 1));
        }

        stringBuilder.AppendLine($"{indentation}{EndToken}");

        return stringBuilder.ToString();
    }
}
