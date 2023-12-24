namespace Kakt.Modding.Core.Skills;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class RequiresEffect(Effect effect) : Attribute
{
    public Effect Effect { get; } = effect;
}
