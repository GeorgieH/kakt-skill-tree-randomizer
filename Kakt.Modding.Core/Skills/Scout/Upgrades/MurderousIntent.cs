namespace Kakt.Modding.Core.Skills.Scout.Upgrades;

public class MurderousIntent : ScoutUpgrade
{
    public MurderousIntent()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__scout_murderousIntent";
}
