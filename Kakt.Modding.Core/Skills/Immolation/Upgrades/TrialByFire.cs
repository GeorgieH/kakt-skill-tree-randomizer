namespace Kakt.Modding.Core.Skills.Immolation.Upgrades;

public class TrialByFire : SkillUpgrade<Immolation>
{
    public TrialByFire()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirPercivale__immolation_trialbyFire";
}
