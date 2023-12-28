namespace Kakt.Modding.Core.Skills.SummonLostCommoner.Upgrades;

public class Purposefulness : SkillUpgrade<SummonLostCommoner>
{
    public Purposefulness()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__summonLostCommoner_purposefulness";
}
