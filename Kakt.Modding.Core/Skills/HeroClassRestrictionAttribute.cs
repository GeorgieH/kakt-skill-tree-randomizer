using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Core.Skills;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class HeroClassRestrictionAttribute(HeroClass heroClass) : Attribute
{
    public HeroClass HeroClass { get; } = heroClass;
}
