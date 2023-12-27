namespace Kakt.Modding.Configuration.IO;

public class CfgDocument
{
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

        foreach (var line in File.ReadLines(path))
        {
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
}
