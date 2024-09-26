using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_3
{
    public abstract class Ball
    {
        protected Vector2 position;
        protected Texture2D texture;
        public Ball(Texture2D texture, Vector2 position){
            this.texture = texture;
            this.position = position;
        }
        public abstract void Update();

        public void Draw(SpriteBatch spriteBatch){
            Rectangle rectangle = new Rectangle(position.ToPoint(), new Point(50, 50));
            spriteBatch.Draw(texture, rectangle, Color.AliceBlue);
        }
    }
}