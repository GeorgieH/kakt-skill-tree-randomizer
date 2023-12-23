namespace Kakt.Modding.Core;

[AttributeUsage(AttributeTargets.Class)]
public class ConfigurationElementAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}
