namespace Kakt.Modding.Core.KnightsTale.Skills.Shoot.Upgrades;

public class Torture : ShootUpgrade
{
    public Torture()
    {
        Name = nameof(Torture);
        CodeName = "Hero_marksman__shoot_torture";
        PrerequisiteEffects = Effects.Burn | Effects.Poison;
    }
}
