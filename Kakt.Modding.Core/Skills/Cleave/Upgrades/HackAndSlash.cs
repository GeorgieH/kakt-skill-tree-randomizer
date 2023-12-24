namespace Kakt.Modding.Core.Skills.Cleave.Upgrades;

[CausesEffect(Effect.Knockback)]
public class HackAndSlash : SkillUpgrade<Cleave>
{
    public HackAndSlash()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__cleave_hackAndslash";
}
