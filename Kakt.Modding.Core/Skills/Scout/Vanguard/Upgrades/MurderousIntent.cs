namespace Kakt.Modding.Core.Skills.Scout.Vanguard.Upgrades;

[RequiresSkillAttributes(SkillAttributes.Movement)]
public class MurderousIntent : SkillUpgrade<VanguardScout>
{
    public MurderousIntent()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__scout_murderousIntent";
}
