using System;
using Project.Engine.EventSystem;

namespace Project.Engine
{
    public class GameObject
    {
        private Vector2Int _position;

        public Vector2Int Position
        {
            get => _position;
            set => _position = value ?? throw new ArgumentNullException(nameof(value));
        }

        protected GameObject()
        {
            _position = new Vector2Int(0, 0);
        }

        public virtual void Init()
        {
            
        }

        public virtual void Render()
        {

        }

        public virtual void Update()
        {

        }
        
        public virtual void Update(Event e)
        {

        }
    }
}