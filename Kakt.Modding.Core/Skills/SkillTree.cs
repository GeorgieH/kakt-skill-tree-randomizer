namespace Kakt.Modding.Core.Skills;

public class SkillTree
{
    private readonly Skill[] skills = new Skill[20];

    public IEnumerable<Skill> Skills => skills;

    public ActiveSkill TierOneActiveSkillOne
    {
        get => (ActiveSkill)skills[0];
        set => skills[0] = value;
    }

    public ActiveSkill TierOneActiveSkillTwo
    {
        get => (ActiveSkill)skills[1];
        set => skills[1] = value;
    }

    public ActiveSkill TierOneActiveSkillThree
    {
        get => (ActiveSkill)skills[2];
        set => skills[2] = value;
    }

    public UpgradablePassiveSkill TierOneUpgradablePassiveSkillOne
    {
        get => (UpgradablePassiveSkill)skills[3];
        set => skills[3] = value;
    }

    public PassiveSkill TierOnePassiveSkillOne
    {
        get => (PassiveSkill)skills[4];
        set => skills[4] = value;
    }

    public PassiveSkill TierOnePassiveSkillTwo
    {
        get => (PassiveSkill)skills[5];
        set => skills[5] = value;
    }

    public PassiveSkill TierOnePassiveSkillThree
    {
        get => (PassiveSkill)skills[6];
        set => skills[6] = value;
    }

    public ActiveSkill TierTwoActiveSkillOne
    {
        get => (ActiveSkill)skills[7];
        set => skills[7] = value;
    }

    public ActiveSkill TierTwoActiveSkillTwo
    {
        get => (ActiveSkill)skills[8];
        set => skills[8] = value;
    }

    public UpgradablePassiveSkill TierTwoUpgradablePassiveSkillOne
    {
        get => (UpgradablePassiveSkill)skills[9];
        set => skills[9] = value;
    }

    public ActiveSkill TierTwoActiveSkillThree
    {
        get => (ActiveSkill)skills[10];
        set => skills[10] = value;
    }

    public PassiveSkill TierTwoPassiveSkillOne
    {
        get => (PassiveSkill)skills[11];
        set => skills[11] = value;
    }

    public PassiveSkill TierTwoPassiveSkillTwo
    {
        get => (PassiveSkill)skills[12];
        set => skills[12] = value;
    }

    public ActiveSkill TierThreeActiveSkillOne
    {
        get => (ActiveSkill)skills[13];
        set => skills[13] = value;
    }

    public UpgradablePassiveSkill TierThreeUpgradablePassiveSkillOne
    {
        get => (UpgradablePassiveSkill)skills[14];
        set => skills[14] = value;
    }

    public UpgradablePassiveSkill TierThreeUpgradablePassiveSkillTwo
    {
        get => (UpgradablePassiveSkill)skills[15];
        set => skills[15] = value;
    }

    public ActiveSkill TierThreeActiveSkillTwo
    {
        get => (ActiveSkill)skills[16];
        set => skills[16] = value;
    }

    public PassiveSkill TierThreePassiveSkillOne
    {
        get => (PassiveSkill)skills[17];
        set => skills[17] = value;
    }

    public PassiveSkill TierThreePassiveSkillTwo
    {
        get => (PassiveSkill)skills[18];
        set => skills[18] = value;
    }

    public PassiveSkill TierThreePassiveSkillThree
    {
        get => (PassiveSkill)skills[19];
        set => skills[19] = value;
    }
}
