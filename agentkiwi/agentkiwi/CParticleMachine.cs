using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace agentkiwi
{
    enum type
    {
        ROCKET = 0,
        CANDLE
    }

    class CParticleMachine
    {
        private List<CParticle> _lvl1Part;
        
        Random randomizer = new Random();
        private Vector2 _position;
        private type _type;

        public CParticleMachine(type theType, Vector2 position)
        {
            _lvl1Part = new List<CParticle>(100);
            _type = theType;
            _position = position;
        }

        public void update(GameTime gameTime)
        {
            foreach (CParticle part in _lvl1Part)
            {
                part.update(gameTime);
            }

            if (_type == type.ROCKET)
            {
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 5), _position, randomizer.Next(50, 80), new Vector2(145, 225)));

                _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 3), _position, randomizer.Next(70, 100), new Vector2(160, 210)));
                _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 3), _position, randomizer.Next(70, 100), new Vector2(145, 210)));
                _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 3), _position, randomizer.Next(70, 100), new Vector2(160, 210)));
                _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 3), _position, randomizer.Next(70, 100), new Vector2(145, 210)));
                _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 3), _position, randomizer.Next(70, 100), new Vector2(160, 210)));
                _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 3), _position, randomizer.Next(70, 100), new Vector2(145, 210)));
                _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 3), _position, randomizer.Next(70, 100), new Vector2(160, 210)));
                _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 3), _position, randomizer.Next(70, 100), new Vector2(145, 210)));

                _lvl1Part.Add(new CParticle(new Color(255, 30, 0), randomizer.Next(1, 2), _position, randomizer.Next(90, 120), new Vector2(170, 190)));
                _lvl1Part.Add(new CParticle(new Color(255, 30, 0), randomizer.Next(1, 2), _position, randomizer.Next(90, 120), new Vector2(170, 190)));
                _lvl1Part.Add(new CParticle(new Color(255, 30, 0), randomizer.Next(1, 2), _position, randomizer.Next(90, 120), new Vector2(170, 190)));
                _lvl1Part.Add(new CParticle(new Color(255, 30, 0), randomizer.Next(1, 2), _position, randomizer.Next(90, 120), new Vector2(170, 190)));
                _position.X += 6;

                if (_position.X >= 1700)
                {
                    _position.X = -225;
                    thefunguy.position.X = -240;
                }
            }
            else
            {
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 3), _position, randomizer.Next(50, 80), new Vector2(70, 110)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 3), _position, randomizer.Next(50, 80), new Vector2(70, 110)));
                _lvl1Part.Add(new CParticle(new Color(255, 255, 0), randomizer.Next(1, 3), _position, randomizer.Next(50, 80), new Vector2(70, 110)));

                _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 2), _position, randomizer.Next(70, 100), new Vector2(80, 100)));
                _lvl1Part.Add(new CParticle(new Color(255, 150, 0), randomizer.Next(1, 2), _position, randomizer.Next(70, 100), new Vector2(80, 100)));

                _lvl1Part.Add(new CParticle(new Color(255, 30, 0), randomizer.Next(1, 2), _position, randomizer.Next(90, 120), new Vector2(85, 95)));
            }


            _lvl1Part.RemoveAll(p => p.dead == true);

            
            
        }

        public void draw(SpriteBatch spriteBatch)
        {
            foreach (CParticle part in _lvl1Part)
                part.draw(spriteBatch);
        }


    }
}
