namespace Project.Engine
{
    public class Character : GameObject
    {
        public override void Init()
        {
            base.Init();
        }

        public override void Update()
        {
            Console.WriteLine("Go forward - w, back - s, left - a, right - d");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.W:
                    Position += new Vector2Int(0, 1);
                    break;
                case ConsoleKey.S:
                    Position += new Vector2Int(0, -1);
                    break;
                case ConsoleKey.D:
                    Position += new Vector2Int(1, 0);
                    break;
                case ConsoleKey.A:
                    Position += new Vector2Int(-1, 0);
                    break;
            }
        }

        public override void Render()
        {
            Console.WriteLine("Character");
            base.Render();
        }
    }
}