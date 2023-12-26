﻿namespace Kakt.Modding.Core.Skills.GasTrap.Upgrades;

public class CorrosivePoison : SkillUpgrade<GasTrap>
{
    public CorrosivePoison()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__poisonTrap_corrosivePoison";
}
