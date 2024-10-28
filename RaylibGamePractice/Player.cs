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
        private Vector3 _position = new Vector3(10, 10, 0);
        private Vector3 _size = new Vector3(10, 10, 0);
        private Color _color = Color.Green;
        private float _speed =  150.0f;
        private Matrix3 _transform = new Matrix3(
            10, 10, 1,
            10, 10, 1,
            0, 0, 1);

        public Player(Vector3 position, Vector3 size, Color color, float speed)
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
                    Raylib.IsKeyDown(KeyboardKey.S) - Raylib.IsKeyDown(KeyboardKey.W)).Normalized * _speed * Raylib.GetFrameTime();

            // feed the movement input into hte move function
            Move(movementInput);
            Render();
        }
        private void Move(Vector2 direction)
        {
            // update the player's position
            _transform *= Matrix3.CreateTranslation(direction.x, direction.y);
            Console.WriteLine(direction.x + ", " + direction.y);

            // update the player's rotation
        }
        private void Shoot()
        {
            Vector2 bulletDirection = new Vector2();
        }
        public void Render()
        {
            Raylib.DrawPoly(
                new Vector2(_transform.m02, _transform.m12), 
                4, 
                10, 
                45, 
                _color);
        }
        
    }
}
