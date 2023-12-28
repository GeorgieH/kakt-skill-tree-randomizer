namespace Kakt.Modding.Core.Skills.MindFog.Upgrades;

[CausesEffects(Effects.Weakness)]
public class MindDrain : SkillUpgrade<MindFog>
{
    public MindDrain()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__mindFog_mindDrain";
}
