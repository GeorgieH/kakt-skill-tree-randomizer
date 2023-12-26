﻿using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Randomization.Skills.Default.Filters;

public partial class HeroClassSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;

    public HeroClassSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var skillTypes = input.Hero switch
        {
            Champion => ChampionSkills,
            _ => throw new NotImplementedException()
        };

        input.SkillTypes = input.SkillTypes.Intersect(skillTypes);

        return this.next.SelectSkill(input);
    }
}