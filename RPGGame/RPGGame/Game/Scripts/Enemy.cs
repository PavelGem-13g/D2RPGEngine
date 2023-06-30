namespace Project.Engine;

public class Enemy : GameObject
{
    public override void Update()
    {
        base.Update();
    }

    public override void Render()
    {
        Console.WriteLine("Enemy");
        base.Render();
    }
}