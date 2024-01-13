namespace Kakt.Modding.Domain.Skills.Strike.Sage.Upgrades;

public class Splinter : SkillUpgrade
{
    public Splinter()
    {
        Name = nameof(Splinter);
        CodeName = "Hero_sage__strike_splinter";
        PrerequisiteEffects = Effects.Freeze;
    }
}
