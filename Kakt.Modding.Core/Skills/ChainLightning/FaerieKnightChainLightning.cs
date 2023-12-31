﻿namespace Kakt.Modding.Core.Skills.ChainLightning;

[SkillUpgradeType(typeof(ChainLightning))]
public class FaerieKnightChainLightning : ChainLightning
{
    public FaerieKnightChainLightning()
    {
        IconName = "SirMordred__chainLightning";
    }

    public override string Name => "FaerieKnight__chainLightning";
}
