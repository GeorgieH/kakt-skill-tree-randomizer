﻿namespace Kakt.Modding.Core.Skills.LightningCleave;

[SkillAttributes(SkillAttributes.Melee | SkillAttributes.Area | SkillAttributes.Lightning)]
[CausesEffects(Effects.Shock)]
public class LightningCleave : ActiveSkill
{
    public override string Name => "SirMordred__lightningCleave";
}
