namespace Kakt.Modding.Core.Skills.RayOfLight.Upgrades;

public class FocusedBeam : SkillUpgrade<RayOfLight>
{
    public FocusedBeam()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__rayofLight_focusedBeam";
}
