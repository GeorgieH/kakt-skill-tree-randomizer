namespace Kakt.Modding.Domain.Heroes;

public class Merlin : Arcanist
{
    public Merlin()
    {
        Traits = HeroTraits.Skilled;
    }

    public override string Name => nameof(Merlin);
}
