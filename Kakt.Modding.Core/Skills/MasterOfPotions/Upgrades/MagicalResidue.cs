namespace Kakt.Modding.Core.Skills.MasterOfPotions.Upgrades;

public class MagicalResidue : SkillUpgrade<MasterOfPotions>
{
    public MagicalResidue()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirDagonet__masterofPotions_magicalResidue";
}
