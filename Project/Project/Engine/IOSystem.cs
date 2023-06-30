using Avalonia.Controls;

namespace Project.Engine;

public static class IOSystem
{
    private static Window _window;

    private static StackPanel _stackPanel;

    public static Window Window => _window;

    public static StackPanel StackPanel => _stackPanel;

    public static void Init(Window window, StackPanel stackPanel)
    {
        _window = window;
        _stackPanel = stackPanel;
    }
}