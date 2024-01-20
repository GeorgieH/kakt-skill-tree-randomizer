namespace Kakt.Modding.Core.KnightsTale.Heroes;

public interface IHeroRepository
{
    IEnumerable<Hero> GetAll();
}

public class HeroRepository : IHeroRepository
{
    private static readonly HashSet<Hero> heroes =
    [
        new BlackKnight(),
        new FaerieKnight(),
        new LadyBoudicea(),
        new LadyDindraine(),
        new LadyGuinevere(),
        new LadyIsolde(),
        new LadyMorganaLeFay(),
        new LadyMorgawse(),
        new Merlin(),
        new RedKnight(),
        new SirBalan(),
        new SirBalin(),
        new SirBedievere(),
        new SirBors(),
        new SirBrunorLeNoir(),
        new SirDagonet(),
        new SirDamas(),
        new SirEctor(),
        new SirGalahad(),
        new SirGawain(),
        new SirGeraint(),
        new SirKay(),
        new SirLancelot(),
        new SirLanval(),
        new SirLeodegrance(),
        new SirLucan(),
        new SirMordred(),
        new SirPelleas(),
        new SirPercival(),
        new SirTegyr(),
        new SirTristan(),
        new SirYvain(),
        new WhiteKnight()
    ];

    public IEnumerable<Hero> GetAll()
    {
        return heroes;
    }
}
