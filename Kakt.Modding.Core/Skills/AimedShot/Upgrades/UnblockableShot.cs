namespace Kakt.Modding.Core.Skills.AimedShot.Upgrades;

public class UnblockableShot : SkillUpgrade<AimedShot>
{
    public UnblockableShot()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__aimedShot_unblockableShot";
}
