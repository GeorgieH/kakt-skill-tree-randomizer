namespace Kakt.Modding.Core.Skills.SummonLostKnight.Upgrades;

public class WartimeMemories : SkillUpgrade<SummonLostKnight>
{
    public WartimeMemories()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__summonLostKnight_wartimeMemories";
}
