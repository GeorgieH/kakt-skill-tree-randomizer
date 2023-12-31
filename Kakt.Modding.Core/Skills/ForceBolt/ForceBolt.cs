﻿namespace Kakt.Modding.Core.Skills.ForceBolt;

[ConfigurationElement(nameof(ForceBolt))]
[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell)]
[CausesEffects(Effects.Knockback)]
public class ForceBolt : ActiveSkill
{
    public override string Name => "Hero_arcanist__forceBolt";
}
