namespace Kakt.Modding.Domain.Skills;

public class SkillPositionCalculatorOutput
{
    public SkillPositionCalculatorOutput(
        Position2D skillPosition)
    {
        SkillPosition = skillPosition;
    }

    public SkillPositionCalculatorOutput(
        Position2D skillPosition,
        Position2D skillUpgradePosition1,
        Position2D skillUpgradePosition2,
        Position2D skillUpgradePosition3,
        Position2D skillUpgradePosition4)
    {
        SkillPosition = skillPosition;
        SkillUpgradePosition1 = skillUpgradePosition1;
        SkillUpgradePosition2 = skillUpgradePosition2;
        SkillUpgradePosition3 = skillUpgradePosition3;
        SkillUpgradePosition4 = skillUpgradePosition4;
    }

    public Position2D SkillPosition { get; }
    public Position2D SkillUpgradePosition1 { get; }
    public Position2D SkillUpgradePosition2 { get; }
    public Position2D SkillUpgradePosition3 { get; }
    public Position2D SkillUpgradePosition4 { get; }
}
