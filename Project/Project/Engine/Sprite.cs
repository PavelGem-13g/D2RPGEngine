using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media.Imaging;

namespace Project.Engine;

public class Sprite:GameObject
{
    private GameObject _parent;
    private string _path;
    private Vector2Int _size;

    private Image _image;

    public GameObject Parent
    {
        get => _parent;
        set => _parent = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Path
    {
        get => _path;
        set => _path = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Vector2Int Size
    {
        get => _size;
        set => _size = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Sprite(GameObject parent, string path, Vector2Int size)
    {
        _parent = parent;
        _path = path;
        _size = size;
        _image = new Image();
    }

    public void Render()
    {
// Установите изображение
        _image.Source = new Bitmap(_path);

// Установите размер изображения
        _image.Width = _size.X;
        _image.Height = _size.Y;

// Установите позицию изображения
        _image.Margin = new Thickness(_parent.Position.X, _parent.Position.Y, 0, 0);

// Установите горизонтальное и вертикальное выравнивание изображения
        _image.HorizontalAlignment = HorizontalAlignment.Left;
        _image.VerticalAlignment = VerticalAlignment.Top;

        IOSystem.StackPanel.Children.Add(_image);
    }
}