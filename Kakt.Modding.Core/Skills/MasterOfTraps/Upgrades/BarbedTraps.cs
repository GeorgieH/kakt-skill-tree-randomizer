namespace Kakt.Modding.Core.Skills.MasterOfTraps.Upgrades;

public class BarbedTraps : SkillUpgrade<MasterOfTraps>
{
    public BarbedTraps()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__masterOftraps_barbedTraps";
}
