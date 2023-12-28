namespace Kakt.Modding.Core.Skills.MasterOfFire.Upgrades;

public class Inferno : SkillUpgrade<MasterOfFire>
{
    public Inferno()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__masterofFire_inferno";
}
