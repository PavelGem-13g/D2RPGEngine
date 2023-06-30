namespace Project.Engine;

public class Vector2Int
{
    private int _x;
    private int _y;

    public int X
    {
        get => _x;
        set => _x = value;
    }

    public int Y
    {
        get => _y;
        set => _y = value;
    }

    public Vector2Int()
    {
        _x = 0;
        _y = 0;
    }
    
    public Vector2Int(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public static Vector2Int operator +(Vector2Int first, Vector2Int second)
    {
        return new Vector2Int(first.X + second.X, first.Y + second.Y);
    }
    
    public static Vector2Int operator -(Vector2Int first, Vector2Int second)
    {
        return new Vector2Int(first.X - second.X, first.Y - second.Y);
    }

    public double Length
    {
        get => Math.Sqrt(X * X + Y * Y);
    }

    public string ToString()
    {
        return X + " " + Y;
    }
}