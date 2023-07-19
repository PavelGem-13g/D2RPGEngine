namespace MyApp;

public abstract class AssetContainer<T>
{    
    private List<T> _values;

    public AssetContainer(List<T> values)
    {
        _values = values;
    }

    public void Add()
    {
        throw new NotImplementedException();
    }

    public void Remove()
    {
        throw new NotImplementedException();
    }
}