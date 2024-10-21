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
            this._position = position;
            this._size = size;
            this._color = color;
            this._speed = speed;
        }
        public void Update()
        {
            Vector2 moveDirection = new Vector2(0, 0);

            // check if each key is down, and change the move direction accordingly
            if (Raylib.IsKeyDown(KeyboardKey.Up))
            {
                moveDirection += new Vector2(0, -1);
            }
            if (Raylib.IsKeyDown(KeyboardKey.Down))
            {
                moveDirection += new Vector2(0, 1);
            }
            if (Raylib.IsKeyDown(KeyboardKey.Left))
            {
                moveDirection += new Vector2(-1, 0);
            }
            if (Raylib.IsKeyDown(KeyboardKey.Right))
            {
                moveDirection += new Vector2(1, 0);
            }

            //normalize the move direction, then move and render
            Move(moveDirection.Normalized);
            Render();
        }

        private void Move(Vector2 direction)
        {
            // TO DO: make the speed consistent (i have no idea why this doesnt work for that)
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
