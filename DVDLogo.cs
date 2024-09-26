

using System.Numerics;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_3
{
    public class DVDLogo : Ball
    {
        Vector2 velocity = new Vector2(50,70);
        public DVDLogo(Texture2D texture) : base(texture, new Vector2(50,50)){}
        public override void Update()
        {
            position += velocity * 1f/60f;
            if(position.X <= 0 || position.X + 50 >= 800){
                velocity.X *= -1;
            }
            if(position.Y <= 0 || position.Y + 50 >= 480){
                velocity.Y *= -1;
            }
        }
    }
}