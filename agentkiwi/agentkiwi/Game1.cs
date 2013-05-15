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
        CCandle[] candle = new CCandle[25];
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
            machine = new CParticleMachine(type.ROCKET, new Vector2(-725,100));

            cakerect = new Rectangle(0, 0, screenWidth, screenHeight);
            caketex = Content.Load<Texture2D>("cake");
            candletex = Content.Load<Texture2D>("candle");
            thefunguy.fun = Content.Load<Texture2D>("thefun");
            CCandle.candle = candletex;

            candle[0] = new CCandle(new Vector2(130,330));
            candle[1] = new CCandle(new Vector2(200, 340));
            candle[2] = new CCandle(new Vector2(160, 320));
            candle[3] = new CCandle(new Vector2(600, 120));
            candle[4] = new CCandle(new Vector2(550, 160));
            candle[5] = new CCandle(new Vector2(650, 160));
            candle[6] = new CCandle(new Vector2(300, 350));
            candle[7] = new CCandle(new Vector2(340, 360));
            candle[8] = new CCandle(new Vector2(390, 370));
            candle[9] = new CCandle(new Vector2(440, 400));
            candle[10] = new CCandle(new Vector2(490, 380));
            candle[11] = new CCandle(new Vector2(530, 385));
            candle[12] = new CCandle(new Vector2(590, 400));
            candle[13] = new CCandle(new Vector2(630, 390));
            candle[14] = new CCandle(new Vector2(680, 390));
            candle[15] = new CCandle(new Vector2(780, 370));
            candle[16] = new CCandle(new Vector2(830, 380));
            candle[17] = new CCandle(new Vector2(870, 360));
            candle[18] = new CCandle(new Vector2(920, 355));
            candle[19] = new CCandle(new Vector2(970, 330));
            candle[20] = new CCandle(new Vector2(1020, 350));
            candle[21] = new CCandle(new Vector2(1170, 300));
            candle[22] = new CCandle(new Vector2(1130, 290));
            candle[23] = new CCandle(new Vector2(1090, 340));
            candle[24] = new CCandle(new Vector2(1050, 350));


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

            foreach (CCandle x in candle)
                x.update(gameTime);

            thefunguy.update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            
            spriteBatch.Draw(caketex, cakerect, Color.White);

            foreach (CCandle x in candle)
                x.draw(spriteBatch);

            thefunguy.draw(spriteBatch);

            machine.draw(spriteBatch);


            spriteBatch.DrawString(mainfont, "Happy Birthday Ash!", new Vector2(190,590), Color.Black);
            spriteBatch.DrawString(smallfont, "with love from\nsteve calandra & chris bebry", new Vector2(1060, 680), Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
