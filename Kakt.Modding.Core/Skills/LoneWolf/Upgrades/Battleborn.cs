namespace Kakt.Modding.Core.Skills.LoneWolf.Upgrades;

public class Battleborn : SkillUpgrade<LoneWolf>
{
    public Battleborn()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirLancelot__loneWolf_battleborn";
}
