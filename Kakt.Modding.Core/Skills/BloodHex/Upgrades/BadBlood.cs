namespace Kakt.Modding.Core.Skills.BloodHex.Upgrades;

public class BadBlood : SkillUpgrade<BloodHex>
{
    public BadBlood()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__bloodCurse_badBlood";
}
