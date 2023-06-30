using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Controls;
using Project.Engine.EventSystem;

namespace Project.Engine
{
    public static class GameSync
    {
        private static List<GameObject> _gameObjects;
        private static List<Event> _events;
        public static void Init(Window window, StackPanel stackPanel)
        {
            IOSystem.Init(window, stackPanel);
            _gameObjects = new List<GameObject>();
            _events = new List<Event>();
        }

        public static void Add(GameObject gameObject)
        {
            _gameObjects.Add(gameObject);
            gameObject.Init();
        }

        public static async void Pipeline()
        {
            await Task.Run(() =>
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

                        Thread.Sleep(100);   
                    }
                }
            );
        }
    }        
}
