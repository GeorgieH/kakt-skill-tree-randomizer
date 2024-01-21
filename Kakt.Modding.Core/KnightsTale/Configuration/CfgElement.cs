namespace Kakt.Modding.Core.KnightsTale.Configuration;

public abstract class CfgElement
{
    public virtual CfgElement? this[string name]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public abstract string Name { get; }

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
