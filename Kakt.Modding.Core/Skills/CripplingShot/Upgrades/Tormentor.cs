namespace Kakt.Modding.Core.Skills.CripplingShot.Upgrades;

public class Tormentor : SkillUpgrade<CripplingShot>
{
    public Tormentor()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirDamas__cripplingShot_tormentor";
}
