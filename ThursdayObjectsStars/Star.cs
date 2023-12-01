using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThursdayObjectsStars
{
    internal class Star
    {

        private Vector2 _position;
        private Texture2D _starTexture;
        private Random _rng;
        private float _scale, _rotation, _transparency, _rotationSpeed;
        private Color _color;


        public Star(Texture2D textureIn)
        {
            _rng = new Random();
            _position = new Vector2(_rng.Next(0, 801), _rng.Next(0, 481));
            _starTexture = textureIn;
            _scale = _rng.Next(10, 76) / 100f;
            _rotation = _rng.Next(0, 100) / 100f;
            _rotationSpeed = _rng.Next(1, 100) / 2500f;
            _transparency = _rng.Next(25, 100) / 100f;
            _color = new Color(128 + _rng.Next(0,128), 128 + _rng.Next(0, 128), 128 + _rng.Next(0, 128));
        }

        public void Draw(SpriteBatch spriteBatchIn)
        {
            spriteBatchIn.Begin();
            spriteBatchIn.Draw(_starTexture, _position,
                null,
                _color * _transparency,
                _rotation,
                new Vector2(_starTexture.Width / 2, _starTexture.Height / 2),
                new Vector2(_scale, _scale),
                SpriteEffects.None,
                0);
            spriteBatchIn.End();
        }

        public void Update()
        {
            if (_position.X < 400)
            {
                _rotation -= _rotationSpeed;
                _position.X -= _rotationSpeed * 100;
            }
            else
            {
                _rotation += _rotationSpeed;
                _position.X += _rotationSpeed * 100;
            }

        }
    }
}
