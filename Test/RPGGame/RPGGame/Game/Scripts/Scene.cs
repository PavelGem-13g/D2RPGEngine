namespace Project.Engine;

public class Scene
{
    public void Init()
    {
        GameSync.Init();
        
        Character character = new Character();
        character.Init("Character");
        GameSync.Add(character);
        
        Enemy enemy = new Enemy();
        enemy.Init("Enemy", new Vector2Int(5,5));
        GameSync.Add(enemy);

        Chest chest = new Chest();
        chest.Init("Chest", new Vector2Int(-10, 0));
        GameSync.Add(chest);
    }

    public void Pipeline()
    {
        GameSync.Pipeline();
    }

    public static void GameOver(int code)
    {
        GameSync.Stop();
        switch (code)
        {
            case 0:
                Console.WriteLine("You died");
                break;
            case 1:
                Console.WriteLine("You found prize! Congratulations!");
                break;
        }
    }
}