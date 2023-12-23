namespace Kakt.Modding.Core.Skills.Cleave.Upgrades;

public class HackAndSlash : CleaveUpgrade
{
    public HackAndSlash()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__cleave_hackAndslash";
}
