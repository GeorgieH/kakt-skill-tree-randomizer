﻿namespace Kakt.Modding.Core.Skills.DazingStrikes.Upgrades;

public class ExtraStun : DazingStrikesUpgrade
{
    public ExtraStun()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__extraStun";
}
