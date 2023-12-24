namespace Kakt.Modding.Core.Skills;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class CausesEffect(Effect effect) : Attribute
{
    public Effect Effect { get; } = effect;
}
