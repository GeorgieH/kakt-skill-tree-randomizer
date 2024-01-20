using System.Text;

namespace Kakt.Modding.Core.KnightsTale.Configuration;

public class CfgDocument
{
    public static readonly string Indent = "    ";

    public CfgElement? this[string name]
    {
        get => Elements.FirstOrDefault(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));
        set
        {
            var index = Elements.FindIndex(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));
            Elements[index] = value!;
        }
    }

    public List<CfgElement> Elements { get; } = [];

    public static CfgDocument Parse(string path)
    {
        var document = new CfgDocument();

        string? previousLine = null;
        var objectStack = new Stack<CfgObject>();

        void AddElement(CfgElement element)
        {
            if (objectStack!.TryPeek(out var obj))
            {
                obj.Elements.Add(element);
            }
            else
            {
                document!.Elements.Add(element);
            }
        }

        foreach (var l in File.ReadLines(path))
        {
            var line = l.Trim();

            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            if (CfgComment.TryParse(line, out var comment))
            {
                AddElement(comment);
            }
            else if (CfgProperty.TryParse(line, out var property))
            {
                AddElement(property);
            }
            else if (line.StartsWith(CfgObject.StartToken))
            {
                var obj = new CfgObject(previousLine!);
                AddElement(obj);
                objectStack.Push(obj);
            }
            else if (line.StartsWith(CfgObject.EndToken))
            {
                objectStack.Pop();
            }
            else
            {
                previousLine = line;
            }
        }

        return document;
    }

    public void OverwriteObject(string name, CfgObject newObj)
    {
        var index = Elements.FindIndex(e => e is CfgObject o
                && string.Equals(o.Name, name, StringComparison.OrdinalIgnoreCase));

        if (index == -1)
        {
            Elements.Add(newObj);
        }
        else
        {
            Elements[index] = newObj;
        }
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        foreach (var element in Elements)
        {
            stringBuilder.AppendLine(element.ToString(0));
        }

        return stringBuilder.ToString();
    }
}
