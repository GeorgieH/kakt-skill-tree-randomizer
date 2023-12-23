﻿namespace Kakt.Modding.Core.Skills.FireArrow.Upgrades;

public class HeatedArrow : SkillUpgrade<FireArrow>
{
    public HeatedArrow()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__fireBolt_heatedBolt";
}
