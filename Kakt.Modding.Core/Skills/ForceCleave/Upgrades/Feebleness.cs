﻿namespace Kakt.Modding.Core.Skills.ForceCleave.Upgrades;

[CausesEffect(Effect.Weakness)]
public class Feebleness : SkillUpgrade<ForceCleave>
{
    public Feebleness()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "FaerieKnight__forceCleave_feebleness";
}
