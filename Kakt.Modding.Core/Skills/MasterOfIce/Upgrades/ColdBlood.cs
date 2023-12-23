namespace Kakt.Modding.Core.Skills.MasterOfIce.Upgrades;

public class ColdBlood : SkillUpgrade<MasterOfIce>
{
    public ColdBlood()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__masterOfice_coldBlood";
}
