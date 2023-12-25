namespace Kakt.Modding.Core.Skills.HexCleave.Upgrades;

public class DarkSorcery : SkillUpgrade<HexCleave>
{
    public DarkSorcery()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "BlackKnight__hexCleave_darkSorcery";
}
