namespace Kakt.Modding.Core.Skills.Cleave;

[ConfigurationElement(nameof(Cleave))]
[SkillUpgradeType(typeof(Cleave))]
public class RedKnightCleave : Cleave
{
    public RedKnightCleave()
    {
        CasterName = "Hero_champion__cleave";
    }

    public override string Name => "RedKnight__cleave";
}
