using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lesson_2_Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture, rectangleTexture;

        Rectangle rect1, circle1, topRect, halfRect, centerRect, bottomRect;

        Rectangle Window;

        SpriteFont textFont;
        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            Window = new Rectangle(0, 0, 800, 600);
           
            _graphics.PreferredBackBufferWidth = Window.Width;
            _graphics.PreferredBackBufferHeight = Window.Height;
            _graphics.ApplyChanges();

            rect1 = new Rectangle(50, 50, 75, 200);

            circle1 = new Rectangle(50, 50, 87, 167);

            topRect = new Rectangle(0, 0, Window.Width, 15);

            halfRect = new Rectangle(0, 0, Window.Width / 2, 20);

            centerRect = new Rectangle(Window.Width / 2 - 25, Window.Height / 2, 50, 50);

            bottomRect = new Rectangle(0, Window.Height - 20, Window.Width, 20);

            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            circleTexture = Content.Load<Texture2D>("circle");

            rectangleTexture = Content.Load<Texture2D>("rectangle");

            textFont = Content.Load<SpriteFont>("TextFont");


            
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SteelBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(rectangleTexture, rect1, Color.Lime);

            _spriteBatch.Draw(circleTexture, circle1, Color.Purple);

            _spriteBatch.Draw(rectangleTexture, topRect, Color.Gray);

            _spriteBatch.Draw(rectangleTexture, halfRect, Color.Blue);

            _spriteBatch.Draw(rectangleTexture, centerRect, Color.Yellow);

            _spriteBatch.Draw(rectangleTexture, bottomRect, Color.Red);

            _spriteBatch.DrawString(textFont, "wdp, Sigma.", new Vector2 (100, 100), Color.Brown);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
