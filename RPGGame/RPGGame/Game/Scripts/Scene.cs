namespace Project.Engine;

public class Scene
{
    public void Init()
    {
        GameSync.Init();
        GameSync.Add(new Character());
        GameSync.Add(new Enemy());
    }

    public void Pipeline()
    {
        GameSync.Pipeline();
    }
}