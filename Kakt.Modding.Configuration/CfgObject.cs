using System.Text;

namespace Kakt.Modding.Configuration;

public class CfgObject : CfgElement
{
    public static readonly string StartToken = "{";
    public static readonly string EndToken = "}";

    public CfgObject(string name)
    {
        Name = name;
    }

    public override CfgElement? this[string name]
    {
        get => Elements.FirstOrDefault(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));
        set
        {
            var index = Elements.FindIndex(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));
            Elements[index] = value!;
        }
    }

    public List<CfgElement> Elements { get; } = [];

    public override string Name { get; }

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
