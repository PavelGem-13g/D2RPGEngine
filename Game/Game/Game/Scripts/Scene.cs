using Avalonia.Controls;

namespace Project.Engine;

public class Scene
{
    public void Init(Window window, StackPanel stackPanel)
    {
        GameSync.Init(window, stackPanel);
        GameSync.Add(new Character());
    }

    public void Pipeline()
    {
        GameSync.Pipeline();
    }
}