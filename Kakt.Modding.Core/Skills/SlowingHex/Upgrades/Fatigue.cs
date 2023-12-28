namespace Kakt.Modding.Core.Skills.SlowingHex.Upgrades;

public class Fatigue : SkillUpgrade<SlowingHex>
{
    public Fatigue()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__curse_fatigue";
}
