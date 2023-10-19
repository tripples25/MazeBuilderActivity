namespace MazeBuilder;

public class ScaryMazeBuilder : MazeBuilder<ScaryMazeBuilder>
{
    public ScaryMazeBuilder AddGhost(int x, int y)
    {
        return this;
    }
    
    public ScaryMazeBuilder AddZombie(int x, int y)
    {
        return this;
    }
}