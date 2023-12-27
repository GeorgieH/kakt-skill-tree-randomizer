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
}
