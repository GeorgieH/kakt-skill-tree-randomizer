namespace Kakt.Modding.Configuration;

public abstract class CfgElement
{
    public abstract string ToString(int indentationLevel);

    protected static string GetIndentation(int indentationLevel)
    {
        var indentation = string.Empty;

        if (indentationLevel > 0)
        {
            indentation = string.Concat(Enumerable.Repeat(CfgDocument.Indent, indentationLevel));
        }

        return indentation;
    }
}
