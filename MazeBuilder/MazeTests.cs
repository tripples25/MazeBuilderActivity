﻿namespace MazeBuilder;

public static class MazeTests
{
    public static void TestBuilder_Ok()
    {
        var builder = new ScaryMazeBuilder();
        var maze = builder
            .AddGhost(5, 5)
            .AddGhost(15, 5)
            .AddRock(5, 6)
            .AddRock(5, 4)
            .AddRock(4, 5)
            .Build();
    }
    
    public static void TestBuilder_ShouldBeOk()
    {
        var builder = new ScaryMazeBuilder();
        var maze = builder
            .AddRock(5, 6)
            .AddZombie(5, 9)
            .AddRock(5, 4)
            .AddRock(4, 5)
            .AddGhost(5, 5)
            .AddGhost(15, 5)
            .Build();
    }
}