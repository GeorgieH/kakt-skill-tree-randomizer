﻿namespace Kakt.Modding.Core.Skills.SoothingWords.Upgrades;

public class Healer : SkillUpgrade<SoothingWords>
{
    public Healer()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__soothingWords_healer";
}
