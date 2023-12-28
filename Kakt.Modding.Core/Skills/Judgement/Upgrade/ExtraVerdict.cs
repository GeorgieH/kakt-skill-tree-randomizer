namespace Kakt.Modding.Core.Skills.Judgement.Upgrade;

public class ExtraVerdict : SkillUpgrade<Judgement>
{
    public ExtraVerdict()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__judgement_extraVerdict";
}
