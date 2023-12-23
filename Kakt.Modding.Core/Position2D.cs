﻿namespace Kakt.Modding.Core;

public readonly struct Position2D(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;
}
