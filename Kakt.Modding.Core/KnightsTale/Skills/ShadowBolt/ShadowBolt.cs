﻿namespace Kakt.Modding.Core.KnightsTale.Skills.ShadowBolt;

public class ShadowBolt : ActiveSkill
{
    public ShadowBolt()
    {
        Name = nameof(ShadowBolt);
        CodeName = "SirDagonet__shadowBolt";
        ConfigurationName = Name;
        Attributes = SkillAttributes.Ranged | SkillAttributes.Spell;
    }
}
