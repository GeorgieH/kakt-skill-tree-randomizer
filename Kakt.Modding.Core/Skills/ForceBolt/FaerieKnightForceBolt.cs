﻿namespace Kakt.Modding.Core.Skills.ForceBolt;

[SkillUpgradeType(typeof(ForceBolt))]
public class FaerieKnightForceBolt : ForceBolt
{
    public FaerieKnightForceBolt()
    {
        IconName = "Hero_arcanist__forceBolt";
    }

    public override string Name => "FaerieKnight__forceBolt";
}
