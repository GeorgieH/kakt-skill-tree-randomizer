namespace Kakt.Modding.Configuration.IO;

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

        if (line.StartsWith("//"))
        {
            comment = new CfgComment(line.Remove(0, 2));
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return $"//{Content}";
    }
}
