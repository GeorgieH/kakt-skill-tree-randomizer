namespace Kakt.Modding.Domain.Heroes;

public class SirGawain : Defender
{
    public SirGawain()
    {
        Traits = HeroTraits.Conservative;
    }

    public override string Name => nameof(SirGawain);
}
