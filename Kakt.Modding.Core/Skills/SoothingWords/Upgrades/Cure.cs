﻿namespace Kakt.Modding.Core.Skills.SoothingWords.Upgrades;

public class Cure : SkillUpgrade<SoothingWords>
{
    public Cure()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__soothingWords_cure";
}
