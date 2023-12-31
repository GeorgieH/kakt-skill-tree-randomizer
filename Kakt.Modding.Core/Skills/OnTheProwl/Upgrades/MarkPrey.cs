﻿namespace Kakt.Modding.Core.Skills.OnTheProwl.Upgrades;

[CausesEffects(Effects.Vulnerability)]
public class MarkPrey : SkillUpgrade<OnTheProwl>
{
    public MarkPrey()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirDamas__ontheProwl_markPrey";
}
