using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace agentkiwi
{
    class CCandle
    {
        public static Texture2D candle;
        private Vector2 _position;
        private CParticleMachine _machine;

        public CCandle(Vector2 position)
        {
            _position = position;
            _machine = new CParticleMachine(type.CANDLE, new Vector2(_position.X + 2, _position.Y));
        }

        public void update(GameTime gameTime)
        {
            _machine.update(gameTime);
        }

        public void draw(SpriteBatch spriteBatch)
        {
            _machine.draw(spriteBatch);
            spriteBatch.Draw(candle, new Rectangle((int)_position.X, (int)_position.Y, candle.Width, candle.Height),Color.White);
        }
    }
}
