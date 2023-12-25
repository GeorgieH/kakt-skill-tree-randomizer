namespace Kakt.Modding.Core.Skills.LightningStrike.Upgrades;

public class Overheat : SkillUpgrade<LightningStrike>
{
    public Overheat()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "FaerieKnight__LightningStrike_overheat";
}
