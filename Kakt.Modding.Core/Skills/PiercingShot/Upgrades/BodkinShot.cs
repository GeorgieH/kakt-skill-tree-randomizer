namespace Kakt.Modding.Core.Skills.PiercingShot.Upgrades;

public class BodkinShot : SkillUpgrade<PiercingShot>
{
    public BodkinShot()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirYvain__piercingShot_bodkinShot";
}
