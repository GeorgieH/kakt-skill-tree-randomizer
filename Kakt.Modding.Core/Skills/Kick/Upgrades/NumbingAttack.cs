namespace Kakt.Modding.Core.Skills.Kick.Upgrades;

public class NumbingAttack : SkillUpgrade<Kick>
{
    public NumbingAttack()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirKay__kick_numbingAttack";
}
