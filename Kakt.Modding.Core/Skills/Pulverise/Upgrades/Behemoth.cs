namespace Kakt.Modding.Core.Skills.Pulverise.Upgrades;

public class Behemoth : SkillUpgrade<Pulverise>
{
    public Behemoth()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__pulverise_behemoth";
}
