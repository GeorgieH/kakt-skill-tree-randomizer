namespace Kakt.Modding.Core.Skills.MonsterHunter.Upgrades;

public class FomoriSlayer : SkillUpgrade<MonsterHunter>
{
    public FomoriSlayer()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirGawain__monsterHunter_fomoriSlayer";
}
