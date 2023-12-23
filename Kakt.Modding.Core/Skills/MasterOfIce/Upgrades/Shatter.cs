namespace Kakt.Modding.Core.Skills.MasterOfIce.Upgrades;

public class Shatter : SkillUpgrade<MasterOfIce>
{
    public Shatter()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__masterOfice_shatter";
}
