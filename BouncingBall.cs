using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_3
{
    public class BouncingBall : Ball
    {
        float velocity = 0;
        public BouncingBall(Texture2D texture) : base(texture, new Vector2(50, 50)){}
        public override void Update()
        {
            velocity += 9.82f * 1f/60f;

            if(position.Y + 50 >= 480){
                velocity *= -0.9f;
                position.Y = 430;
            }

            position.Y += velocity;
        }
    }
}