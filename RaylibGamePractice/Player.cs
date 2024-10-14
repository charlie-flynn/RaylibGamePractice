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
        private Vector2 position = new Vector2(10, 10);
        private Vector2 size = new Vector2(10, 10);
        private Color color = Color.Green;
        private float speed =  1.0f;


        public Player(Vector2 position, Vector2 size, Color color, float speed)
        {
            this.position = position;
            this.size = size;
            this.color = color;
            this.speed = speed;
            Raylib.DrawRectangleV(position, size, color);
        }
        public void Update()
        {
            Vector2 moveDirection = new Vector2(0, 0);

            // check if each key is down
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

            //normalize the move direction
            moveDirection.Normalize();

            Move(moveDirection);

            Render();
        }

        private void Move(Vector2 direction)
        {
            // TO DO: make the speed consistent (somethin to do with framerate)
            position += direction * speed * Raylib.GetFrameTime();
        }
        private void Shoot()
        {
            Vector2 bulletDirection = new Vector2();
        }
        public void Render()
        {
            Raylib.DrawRectangleV(position, size, color);
        }
        
    }
}
