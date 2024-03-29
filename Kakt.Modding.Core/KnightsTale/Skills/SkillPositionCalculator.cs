﻿namespace Kakt.Modding.Core.KnightsTale.Skills;

// T = Tier
// S = Skill
// U = Upgrade

// Skill tree layout:
/*
-----------------------------
T1 || S1 | S2 | S3 |
   || S4 | S5 | S6 | S7 |
-----------------------------
T2 || S8  | S9  | S10 |
   || S11 | S12 | S13 |
-----------------------------
T3 || S14 | S15 | S16 |
   || S17 | S18 | S19 | S20 |
-----------------------------
*/

// For each active skill:
/*
------------------------
| U1 |            | U3 |
|    | Skill card |    |
| U2 |            | U4 |
------------------------
*/

// For each passive skill:
/*
---------------------
|    Skill card     |
---------------------
| U1 | U2 | U3 | U4 |
---------------------
*/

public static class SkillPositionCalculator
{
    private const int ActiveSkillOffsetX = 47;
    private const int ActiveSkillOffsetY = 17;

    private const int PassiveSkillFarOffsetX = 44;
    private const int PassiveSkillNearOffsetX = 20;
    private const int PassiveSkillFarOffsetY = 17;
    private const int PassiveSkillNearOffsetY = 42;

    public static SkillPositionCalculatorOutput Calculate(SkillPositionCalculatorInput input)
    {
        var p = input.SkillNumber switch
        {
            1 => SkillPositions.Tier1Skill1,
            2 => SkillPositions.Tier1Skill2,
            3 => SkillPositions.Tier1Skill3,
            4 => input.Skill.Type == SkillType.Active ? SkillPositions.Tier1ActiveSkill4 : SkillPositions.Tier1PassiveSkill4,
            5 => SkillPositions.Tier1Skill5,
            6 => SkillPositions.Tier1Skill6,
            7 => SkillPositions.Tier1Skill7,
            8 => SkillPositions.Tier2Skill1,
            9 => SkillPositions.Tier2Skill2,
            10 => SkillPositions.Tier2Skill3,
            11 => SkillPositions.Tier2Skill4,
            12 => SkillPositions.Tier2Skill5,
            13 => SkillPositions.Tier2Skill6,
            14 => SkillPositions.Tier3Skill1,
            15 => SkillPositions.Tier3Skill2,
            16 => SkillPositions.Tier3Skill3,
            17 => SkillPositions.Tier3Skill4,
            18 => SkillPositions.Tier3Skill5,
            19 => SkillPositions.Tier3Skill6,
            20 => SkillPositions.Tier3Skill7,
            _ => throw SkillNumberOutOfRange(input)
        };

        if (input.Skill.Upgrades.Any())
        {
            int x1 = 0, y1 = 0;
            int x2 = 0, y2 = 0;
            int x3 = 0, y3 = 0;
            int x4 = 0, y4 = 0;

            switch (input.Skill.Type)
            {
                case SkillType.Active:
                    {
                        x1 = x2 = p.X - ActiveSkillOffsetX;
                        y1 = y3 = p.Y - ActiveSkillOffsetY;
                        y2 = y4 = p.Y + ActiveSkillOffsetY;
                        x3 = x4 = p.X + ActiveSkillOffsetX;
                    }
                    break;
                case SkillType.Passive:
                    {
                        x1 = p.X - PassiveSkillFarOffsetX;
                        x2 = p.X - PassiveSkillNearOffsetX;
                        x3 = p.X + PassiveSkillNearOffsetX;
                        x4 = p.X + PassiveSkillFarOffsetX;

                        y1 = y4 = p.Y + PassiveSkillFarOffsetY;
                        y2 = y3 = p.Y + PassiveSkillNearOffsetY;
                    }
                    break;
            }

            return new SkillPositionCalculatorOutput(
                p,
                new Position2D(x1, y1),
                new Position2D(x2, y2),
                new Position2D(x3, y3),
                new Position2D(x4, y4));
        }

        return new SkillPositionCalculatorOutput(p);
    }

    private static ArgumentOutOfRangeException SkillNumberOutOfRange(SkillPositionCalculatorInput input)
    {
        return new ArgumentOutOfRangeException($"The provided skill number is out of range ({input.SkillNumber})");
    }
}
