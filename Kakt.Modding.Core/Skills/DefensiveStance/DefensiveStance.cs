namespace Kakt.Modding.Core.Skills.DefensiveStance;

public class DefensiveStance : Skill
{
    public override int Cost => SkillCosts.Two;
    public override string Name => "Hero_champion__defensiveStance";
    public override SkillType Type => SkillType.Active;
}
