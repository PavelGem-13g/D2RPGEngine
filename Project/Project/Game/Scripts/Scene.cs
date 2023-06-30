using Avalonia.Controls;

namespace Project.Engine;

public class Scene
{
    void Init(Window window, StackPanel stackPanel)
    {
        GameSync.Init(window, stackPanel);
        GameSync.Add(new Character());
    }
}