using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace ThursdayObjectsStars
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _starTexture;

        private List<Star> _myStar;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _starTexture = Content.Load<Texture2D>("Star_Sprite");
            _myStar = new List<Star>();
            for (int i = 0; i < 100; i++) {
                _myStar.Add(new Star(_starTexture));
            }



            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (Star star in _myStar)
                star.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Navy);

            for (int i = 0; i < _myStar.Count; i++)
            {
                _myStar[i].Draw(_spriteBatch);
            }
            

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}