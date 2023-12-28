namespace Kakt.Modding.Core.Skills.Taunt.Upgrades;
public class WarCry : SkillUpgrade<Taunt>
{
    public WarCry()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__taunt_warCry";
}
