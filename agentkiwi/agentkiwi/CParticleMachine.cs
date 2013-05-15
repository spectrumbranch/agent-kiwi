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
        private List<CParticle> _lvl1Part;
        
        Random randomizer = new Random();
        private Vector2 _position = new Vector2(300, 300);

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
            _lvl1Part.Add(new CParticle(new Color(255,255,0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
            _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
            _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));

            _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 3), _position, randomizer.Next(70, 100), new Vector2(160, 210)));
            _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 3), _position, randomizer.Next(70, 100), new Vector2(145, 210)));

            _lvl1Part.Add(new CParticle(new Color(255, 30, 0), randomizer.Next(1, 2), _position, randomizer.Next(90, 120), new Vector2(170, 190)));


            _lvl1Part.RemoveAll(p => p.dead == true);

            _position.X += 3;
            
        }

        public void draw(SpriteBatch spriteBatch)
        {
            foreach (CParticle part in _lvl1Part)
                part.draw(spriteBatch);
        }


    }
}
