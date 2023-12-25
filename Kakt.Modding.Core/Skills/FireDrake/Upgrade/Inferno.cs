namespace Kakt.Modding.Core.Skills.FireDrake.Upgrade;

[CausesEffect(Effect.Burning)]
public class Inferno : SkillUpgrade<FireDrake>
{
    public Inferno()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__fireDrake_inferno";
}
