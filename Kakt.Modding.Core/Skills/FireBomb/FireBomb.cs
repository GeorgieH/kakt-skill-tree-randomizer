﻿namespace Kakt.Modding.Core.Skills.FireBomb;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Fire | SkillAttributes.Area)]
[CausesEffects(Effects.Burn)]
public class FireBomb : ActiveSkill
{
    public override string Name => "Hero_marksman__fireBomb";
}
