namespace Kakt.Modding.Core.Skills.Dash;

[SkillAttributes(SkillAttributes.Movement)]
public class VanguardDash : Dash
{
    public VanguardDash()
    {
        IconName = "Hero_marksman__dash";
    }

    public override string Name => "Hero_vanguard__dash";
}
