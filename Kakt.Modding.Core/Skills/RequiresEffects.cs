namespace Kakt.Modding.Core.Skills;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class RequiresEffects(Effects effects) : Attribute
{
    public Effects Effects { get; } = effects;
}
