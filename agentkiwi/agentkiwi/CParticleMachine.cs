using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace agentkiwi
{
    class CParticleMachine
    {
        private CParticle _particle; //test particle

        public CParticleMachine()
        {
            _particle = new CParticle(new Microsoft.Xna.Framework.Color(255, 255, 255), 5, new Vector2(300, 100), 50, new Vector2(135, 225));
        }

        public void update(GameTime gameTime)
        {
            //this will be changed to work with an array later
            if (_particle != null)
            {
                _particle.update(gameTime);

                if (_particle.dead)
                    _particle = null;
            }

            
        }

        public void draw(SpriteBatch spriteBatch)
        {
            //same thing here
            if (_particle != null)
                _particle.draw(spriteBatch);
        }


    }
}
