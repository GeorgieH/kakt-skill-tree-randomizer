namespace Kakt.Modding.Core.KnightsTale.Skills.Shoot.Upgrades;


public class Thunder : ShootUpgrade
{
    public Thunder()
    {
        Name = nameof(Thunder);
        CodeName = "Hero_marksman__shoot_thunder";
        PrerequisiteEffects = Effects.Shock;
    }
}
