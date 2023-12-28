namespace Kakt.Modding.Core.Skills.Alchemist.Upgrades;

public class MasterPoisoner : SkillUpgrade<Alchemist>
{
    public MasterPoisoner()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__alchemist_masterPoisoner";
}
