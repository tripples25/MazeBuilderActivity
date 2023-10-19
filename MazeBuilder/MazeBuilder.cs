namespace MazeBuilder;

public class MazeBuilder<T> 
    where T : MazeBuilder<T>
{
    protected Maze maze = new Maze();
    
    public T AddRock(int x, int y)
    {
        return (T)this;
    }

    public T AddWater(int x, int y)
    {
        return (T)this;
    }
    
    public Maze Build()
    {
        return maze;
    }
}