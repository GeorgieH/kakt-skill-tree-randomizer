namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public class DefaultRandomizationProfile
{
    public DefaultRandomizationProfileFlags Flags { get; set; } = new();
    public DefaultRandomizationProfileRules Rules { get; set; } = new();
    public DefaultRandomizationProfileSkillPools SkillPools { get; set; } = new();
}
