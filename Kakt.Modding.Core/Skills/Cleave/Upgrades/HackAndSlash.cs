namespace Kakt.Modding.Core.Skills.Cleave.Upgrades;

public class HackAndSlash : CleaveUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Ten;
    public override string Name => "Hero_champion__cleave_hackAndslash";
}
