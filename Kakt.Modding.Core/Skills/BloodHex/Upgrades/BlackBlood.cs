namespace Kakt.Modding.Core.Skills.BloodHex.Upgrades;

public class BlackBlood : SkillUpgrade<BloodHex>
{
    public BlackBlood()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__bloodCurse_blackBlood";
}
