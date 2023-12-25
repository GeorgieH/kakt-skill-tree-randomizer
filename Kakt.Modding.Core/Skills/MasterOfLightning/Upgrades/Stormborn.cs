namespace Kakt.Modding.Core.Skills.MasterOfLightning.Upgrades;

public class Stormborn : SkillUpgrade<MasterOfLightning>
{
    public Stormborn()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__masterofLightning_stormborn";
}
