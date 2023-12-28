namespace Kakt.Modding.Core.Skills.BleedingStrike.Upgrades;

public class TasteTheirBlood : SkillUpgrade<BleedingStrike>
{
    public TasteTheirBlood()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "RedKnight__bleedingStrike_tasteTheirBlood";
}
