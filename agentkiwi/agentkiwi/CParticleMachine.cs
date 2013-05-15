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
        private List<CParticle> _lvl1Part; //fastest particles
        Random randomizer = new Random();

        public CParticleMachine()
        {
            _lvl1Part = new List<CParticle>(100);
        }

        public void update(GameTime gameTime)
        {
            foreach (CParticle part in _lvl1Part)
            {
                part.update(gameTime);
            }
            _lvl1Part.Add(new CParticle(new Color(255, 255, 255), randomizer.Next(1, 5), new Vector2(300, 300), randomizer.Next(50, 80), new Vector2(145, 225)));

            _lvl1Part.RemoveAll(p => p.dead == true);

            
        }

        public void draw(SpriteBatch spriteBatch)
        {
            foreach (CParticle part in _lvl1Part)
                part.draw(spriteBatch);
        }


    }
}
