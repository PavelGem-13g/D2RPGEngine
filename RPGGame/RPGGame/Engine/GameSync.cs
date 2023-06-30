namespace Project.Engine
{
    public static class GameSync
    {
        private static List<GameObject> _gameObjects;
        public static void Init()
        {
            _gameObjects = new List<GameObject>();
        }

        public static void Add(GameObject gameObject)
        {
            _gameObjects.Add(gameObject);
            gameObject.Init();
        }

        public static async void Pipeline()
        {
            while (true)
            {
                foreach (var gameObject in _gameObjects)
                {
                    gameObject.Update();
                }

                foreach (var gameObject in _gameObjects)
                {
                    gameObject.Render();
                }
                //Console.ReadKey();
            }
        }
    }        
}
