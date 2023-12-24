using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Core.Skills.Cleave;

[ConfigurationElement("Cleeve")]
[HeroClassRestriction(HeroClass.Champion)]
[HeroClassRestriction(HeroClass.Defender)]
[HeroClassRestriction(HeroClass.Sage)]
[SkillAttributes(SkillAttributes.Melee | SkillAttributes.Area)]
public class Cleave : ActiveSkill
{
    public override string Name => "Hero_champion__cleave";
}
