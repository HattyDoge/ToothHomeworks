using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace Pong
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D ballTexture;
        private Vector2 ballPosition;
        private float ballSpeed;
        private float movementX;
        private float movementY;
        private Vector2 zioSamPosition;
        private Texture2D zioSamTexture;
        private SpriteFont spriteFont;
        private const float maxSpeed = 50f;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            ballPosition = new Vector2(_graphics.PreferredBackBufferWidth / 2, _graphics.PreferredBackBufferHeight / 2);
            zioSamPosition = new Vector2(_graphics.PreferredBackBufferWidth / 2 + 50, _graphics.PreferredBackBufferHeight / 2 + 50);
            ballSpeed = 50f;
            movementY = 0;
            movementX = 0;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            ballTexture = Content.Load<Texture2D>("ball");
            zioSamTexture = Content.Load<Texture2D>("zioSam");
            spriteFont = Content.Load<SpriteFont>("File");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            var keyboardState = Keyboard.GetState();

            // TODO: Add your update logic here
            
            if (keyboardState.IsKeyDown(Keys.Up))
                movementY -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (keyboardState.IsKeyDown(Keys.Down))
                movementY += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (keyboardState.IsKeyDown(Keys.Right))
                movementX += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (keyboardState.IsKeyDown(Keys.Left))
                movementX -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (movementX > maxSpeed)
                movementX = maxSpeed;
            if (ballPosition.X + movementX < _graphics.PreferredBackBufferWidth - ballTexture.Width && ballPosition.X + movementX > 0)
                ballPosition.X += movementX;
            else
            {
                movementX = -movementX;
                ballPosition.X += movementX;
            }
            if (movementY > maxSpeed)
                movementY = maxSpeed;
            if (ballPosition.Y + movementY < _graphics.PreferredBackBufferHeight - ballTexture.Height && ballPosition.Y + movementY > 0)
                ballPosition.Y += movementY;
            else
            {
                movementY = -movementY;
                ballPosition.Y += movementY;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.GreenYellow);
            _spriteBatch.Begin();
            _spriteBatch.Draw(zioSamTexture, zioSamPosition, Color.White);
            _spriteBatch.Draw(ballTexture, ballPosition, Color.White);

            _spriteBatch.DrawString(spriteFont, $"X:{(int)ballPosition.X} Y:{(int)ballPosition.Y}", new Vector2(0,0), Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.End();
            //SpriteFont spriteFont = ;
            //_spriteBatch.DrawString(spriteFont , "LOLLER", new Vector2(10f, 10f), Color.Aqua );
            base.Draw(gameTime);
            
        }
    }
}