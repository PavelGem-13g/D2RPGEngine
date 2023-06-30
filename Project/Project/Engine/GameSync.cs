using System.Collections.Generic;
using Project.Engine.EventSystem;

namespace Project.Engine
{
    public class GameSync
    {
        private List<GameObject> _gameObjects;

        private List<Event> _events;
        public void Init()
        {
            _gameObjects = new List<GameObject>();
            _events = new List<Event>();
        }

        public void Add(GameObject gameObject)
        {
            _gameObjects.Add(gameObject);
            gameObject.Init();
        }

        public void Pipeline()
        {
            foreach (var gameObject in _gameObjects)
            {
                gameObject.Update();
            }

            foreach (var gameObject in _gameObjects)
            {
                gameObject.Render();
            }
            Pipeline();
        }
        
        
    }        
}
