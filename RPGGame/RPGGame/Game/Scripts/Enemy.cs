namespace Project.Engine;

public class Enemy : GameObject
{
    public override void Update()
    {
        base.Update();
        GameObject character = GameSync.FindGameObjectByName("Character");
        Vector2Int vector = character.Position - Position;
        Console.WriteLine();
        if (Math.Abs(vector.X) > Math.Abs(vector.Y))
        {
            if (vector.X!=0)
            {
                Position += new Vector2Int(vector.X/Math.Abs(vector.X), 0);
            }
        }
        else
        {
            if (vector.Y != 0)
            {
                Position += new Vector2Int(0, vector.Y/Math.Abs(vector.Y));   
            }
        }

        if (vector.X==0 && vector.Y==0)
        {
            Scene.GameOver(0);
        }
    }

    public override void Render()
    {
        Console.WriteLine("Enemy");
        base.Render();
    }
}