using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace agentkiwi
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        CParticleMachine machine = null;
        CCandle candle = new CCandle(new Vector2(300, 300));
        Rectangle cakerect;
        Texture2D caketex;

        Texture2D candletex;

        SpriteFont mainfont;
        SpriteFont smallfont;

        int screenWidth = 1280;
        int screenHeight = 720;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();

            Window.Title = "HAPPY BIRTHDAY ASHLEY FAIRWEATHER!";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            CParticle.box = Content.Load<Texture2D>("box");
            machine = new CParticleMachine(type.ROCKET, new Vector2(200,200));

            cakerect = new Rectangle(0, 0, screenWidth, screenHeight);
            caketex = Content.Load<Texture2D>("cake");
            candletex = Content.Load<Texture2D>("candle");
            CCandle.candle = candletex;

            mainfont = Content.Load<SpriteFont>(@"maintext");
            smallfont = Content.Load<SpriteFont>(@"smalltext");
        }

        protected override void UnloadContent()  {  }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                this.Exit();
            }

            machine.update(gameTime);
            candle.update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            
            spriteBatch.Draw(caketex, cakerect, Color.White);
            //foreach (Vector2 displacement in new Vector2[] { new Vector2(0, 0), new Vector2(100, 100) })
            //{
            //    //spriteBatch.Draw(candletex, new Rectangle((int)displacement.X, (int)displacement.Y, 15, 120), Color.White);
            //}
            candle.draw(spriteBatch);
            machine.draw(spriteBatch);


            spriteBatch.DrawString(mainfont, "Happy Birthday Ash!", new Vector2(190,590), Color.Black);
            spriteBatch.DrawString(smallfont, "with love from\nsteve calandra & chris bebry", new Vector2(1060, 680), Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
