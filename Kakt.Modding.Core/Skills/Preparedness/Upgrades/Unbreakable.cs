namespace Kakt.Modding.Core.Skills.Preparedness.Upgrades;

public class Unbreakable : SkillUpgrade<Preparedness>
{
    public Unbreakable()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirKay__preparedness_unbreakable";
}
