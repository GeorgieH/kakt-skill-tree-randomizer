namespace Kakt.Modding.Core.Skills.FireDrake.Upgrade;

[CausesEffects(Effects.Vulnerability)]
public class DrakesCurse : SkillUpgrade<FireDrake>
{
    public DrakesCurse()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__fireDrake_drakesCurse";
}
