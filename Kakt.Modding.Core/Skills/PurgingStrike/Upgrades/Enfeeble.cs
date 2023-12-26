namespace Kakt.Modding.Core.Skills.PurgingStrike.Upgrades;

[CausesEffects(Effects.Weakness)]
public class Enfeeble : SkillUpgrade<PurgingStrike>
{
    public Enfeeble()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_Sage__purgingStrike_enfeeble";
}
