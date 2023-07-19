using System;

namespace Project.Engine
{
    public class GameObject
    {
        private string _name;
        private Vector2Int _position;

        public Vector2Int Position
        {
            get => _position;
            set => _position = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }
        

        public virtual void Init()
        {
            
        }
        
        public virtual void Init(string name)
        {
            _position = new Vector2Int(0, 0);
            _name = name;
        }
        
        public virtual void Init(string name, Vector2Int position)
        {
            _position = position;
            _name = name;
        }

        public virtual void Render()
        {
            Console.WriteLine("Position is "+ _position.X+" "+ _position.Y);
        }

        public virtual void Update()
        {

        }
    }
}