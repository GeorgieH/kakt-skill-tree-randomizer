namespace Kakt.Modding.Core.Skills.ExtraStun;

[RequiresEffect(Effect.Slow)]
[RequiresEffect(Effect.Stun)]
public class ExtraStun : PassiveSkill
{
    public override string Name => "Hero_champion__extraStun";
}
