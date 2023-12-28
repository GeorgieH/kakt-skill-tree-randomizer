namespace Kakt.Modding.Core.Skills.MasterOfLightning.Upgrades;

public class Channeling : SkillUpgrade<MasterOfLightning>
{
    public Channeling()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__masterofLightning_channeling";
}
