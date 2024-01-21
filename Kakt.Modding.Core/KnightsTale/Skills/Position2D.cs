using System.Diagnostics;

namespace Kakt.Modding.Core.KnightsTale.Skills;

[DebuggerDisplay("X = {X}, Y = {Y}")]
public readonly struct Position2D(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;
}
