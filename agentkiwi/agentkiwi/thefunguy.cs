using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace agentkiwi
{
    class thefunguy
    {
        public static Texture2D fun;
        public static Vector2 position = new Vector2(-740, 40);


        public static void update(GameTime gameTime)
        {
            position.X += 6;
        }

        public static void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(fun, new Rectangle((int)position.X, (int)position.Y, fun.Width, fun.Height), Color.White);
        }

    }
}
