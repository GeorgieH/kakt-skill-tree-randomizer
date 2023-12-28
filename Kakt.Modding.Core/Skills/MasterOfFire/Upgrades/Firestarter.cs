namespace Kakt.Modding.Core.Skills.MasterOfFire.Upgrades;

public class Firestarter : SkillUpgrade<MasterOfFire>
{
    public Firestarter()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__masterofFire_firestarter";
}
