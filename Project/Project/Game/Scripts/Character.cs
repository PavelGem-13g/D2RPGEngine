namespace Project.Engine
{
    public class Character : GameObject
    {
        public Sprite _sprite;

        public override void Init()
        {
            base.Init();
            _sprite = new Sprite(this, "Project/Game/Assets/png-transparent-soldier-animation-army-men-cartoon-army-soldiers-people-grass-fictional-character.png", new Vector2Int(20, 20));
        }

        public override void Render()
        {
            _sprite.Render();
        }
    }
}