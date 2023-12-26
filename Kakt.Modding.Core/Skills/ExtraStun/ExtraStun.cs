namespace Kakt.Modding.Core.Skills.ExtraStun;

[RequiresEffects(Effects.Slow | Effects.Stun)]
public class ExtraStun : PassiveSkill
{
    public override string Name => "Hero_champion__extraStun";
}
