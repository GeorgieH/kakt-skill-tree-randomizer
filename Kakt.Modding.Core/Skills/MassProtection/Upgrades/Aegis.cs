namespace Kakt.Modding.Core.Skills.MassProtection.Upgrades;

public class Aegis : SkillUpgrade<MassProtection>
{
    public Aegis()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__massProtection_aegis";
}
