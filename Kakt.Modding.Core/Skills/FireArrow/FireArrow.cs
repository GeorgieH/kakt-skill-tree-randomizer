﻿namespace Kakt.Modding.Core.Skills.FireArrow;

[ConfigurationElement("FireBolt")]
[SkillAttributes(SkillAttributes.Ranged)]
[CausesEffect(Effect.Burning)]
public class FireArrow : ActiveSkill
{
    public override string Name => "Hero_marksman__fireBolt";
}
