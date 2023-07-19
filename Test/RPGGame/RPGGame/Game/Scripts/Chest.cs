namespace Project.Engine;

public class Chest : GameObject
{
    public override void Update()
    {
        base.Update();
        GameObject character = GameSync.FindGameObjectByName("Character");
        Vector2Int vector = character.Position - Position;

        if (vector.X==0 && vector.Y==0)
        {
            Scene.GameOver(1);
        }
    }

    public override void Render()
    {
        GameObject character = GameSync.FindGameObjectByName("Character");
        Vector2Int vector = character.Position - Position;
        if (vector.Length < 6)
        {
            Console.WriteLine("Chest");
            base.Render();   
        }
    }
}