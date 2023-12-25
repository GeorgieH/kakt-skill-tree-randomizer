namespace Kakt.Modding.Core.Skills.MasterOfPotions.Upgrades;

public class Infusion : SkillUpgrade<MasterOfPotions>
{
    public Infusion()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirDagonet__masterofPotions_infusion";
}
