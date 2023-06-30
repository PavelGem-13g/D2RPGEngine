using Avalonia.Controls;
using Avalonia.Input;

namespace Project.Engine.EventSystem;

public class EventController
{
    void Init(Window window)
    {
        window.KeyDown += KeyDown;
    }

    void KeyDown(object sender, KeyEventArgs e)
    {
        
    }
}