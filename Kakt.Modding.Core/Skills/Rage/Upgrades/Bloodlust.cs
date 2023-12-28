﻿namespace Kakt.Modding.Core.Skills.Rage.Upgrades;

public class Bloodlust : SkillUpgrade<Rage>
{
    public Bloodlust()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__rage_bloodlust";
}
