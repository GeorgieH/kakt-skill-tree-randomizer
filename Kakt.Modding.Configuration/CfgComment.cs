namespace Kakt.Modding.Configuration;

public class CfgComment : CfgElement
{
    public CfgComment(string content)
    {
        Content = content;
    }

    public string Content { get; }

    public static bool TryParse(string line, out CfgComment comment)
    {
        comment = null!;

        var l = line.Trim();

        if (l.StartsWith("//"))
        {
            comment = new CfgComment(l.Remove(0, 2));
            return true;
        }

        return false;
    }

    public override string ToString(int indentationLevel)
    {
        return $"{GetIndentation(indentationLevel)}// {Content}";
    }
}
