using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using MathLibrary;

namespace RaylibGamePractice
{
    internal class Player : IUpdatable, IRenderable
    {
        private Vector2 _position = new Vector2(10, 10);
        private Vector2 _size = new Vector2(10, 10);
        private Color _color = Color.Green;
        private float _speed =  15.0f;

        public Player(Vector2 position, Vector2 size, Color color, float speed)
        {
            _position = position;
            _size = size;
            _color = color;
            _speed = speed;
            
        }
        public void Update()
        {
            // movement code
            Vector2 movementInput = new Vector2
                    (Raylib.IsKeyDown(KeyboardKey.D) - Raylib.IsKeyDown(KeyboardKey.A),
                    Raylib.IsKeyDown(KeyboardKey.S) - Raylib.IsKeyDown(KeyboardKey.W)).Normalized;

            // feed the movement input into hte move function
            Move(movementInput);
            Render();
        }
        private void Move(Vector2 direction)
        {
            // update the player's position
            _position += direction * _speed * Raylib.GetFrameTime();
        }
        private void Shoot()
        {
            Vector2 bulletDirection = new Vector2();
        }
        public void Render()
        {
            Raylib.DrawRectangleV(_position, _size, _color);
        }
        
    }
}
