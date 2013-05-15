using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace agentkiwi
{
    class CParticle
    {
        private Color _color;
        private float _ttl;
        private float _direction;
        private Vector2 _accel;
        private Vector2 _velocity;
        private Vector2 _position;
        public static Texture2D box;
        private bool _dead = false;

        public CParticle(Color color, float ttl, Vector2 startPos, float velocity, Vector2 cone)
        {
            _color = color;
            _ttl = ttl * 60.0f;
            _position = startPos;

            //pick a direction
            Random rand = new Random();
            _direction = rand.Next((int)cone.X, (int)cone.Y);
            _direction *= (float)(Math.PI/180.0);
            _velocity = new Vector2(velocity * (float)Math.Cos(_direction),
                                    velocity * (float)Math.Sin(_direction - Math.PI));

            _accel.X = (_velocity.X) / ttl;
            _accel.Y = (_velocity.Y) / ttl;


        }

        public bool dead
        {
            get
            {
                return _dead;
            }
        }

        public void update(GameTime gametime)
        {
            _position.X += _velocity.X/60.0f;
            _position.Y += _velocity.Y / 60.0f;
            _velocity.X -= _accel.X / 60.0f;
            _velocity.Y -= _accel.Y / 60.0f;

            _ttl -= 1.0f;

            if (_ttl <= 0)
                _dead = true;
        }

        public void draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(box, new Rectangle((int)_position.X, (int)_position.Y, 2, 2), _color);
        }
    }
}
