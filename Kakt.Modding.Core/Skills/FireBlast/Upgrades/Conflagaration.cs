namespace Kakt.Modding.Core.Skills.FireBlast.Upgrades;

public class Conflagaration : SkillUpgrade<FireBlast>
{
    public Conflagaration()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__fireBlast_conflagration";
}
