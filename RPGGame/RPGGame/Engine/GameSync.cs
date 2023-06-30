namespace Project.Engine
{
    public static class GameSync
    {
        private static List<GameObject> _gameObjects;
        private static bool _isActive;
        public static void Init()
        {
            _gameObjects = new List<GameObject>();
            _isActive = true;
        }

        public static void Add(GameObject gameObject)
        {
            _gameObjects.Add(gameObject);
            gameObject.Init();
        }

        public static async void Pipeline()
        {
            while (_isActive)
            {
                foreach (var gameObject in _gameObjects)
                {
                    gameObject.Render();
                }
                
                foreach (var gameObject in _gameObjects)
                {
                    gameObject.Update();
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }

        public static GameObject FindGameObjectByName(string name)
        {
            foreach (var gameObject in _gameObjects)
            {
                if (gameObject.Name == name)
                {
                    return gameObject;
                }
            }

            return null;
        }

        public static void Stop()
        {
            _isActive = false;
        }
    }        
}
