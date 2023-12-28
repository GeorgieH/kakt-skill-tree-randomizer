namespace Kakt.Modding.Core;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class ConfigurationElementAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}
