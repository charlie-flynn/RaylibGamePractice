using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using System.Reflection.Metadata;
using MathLibrary;

namespace RaylibGamePractice
{
    public class Game
    {
        public float frameTime;
        private bool _gameOver = false;
        Player player;
        private bool _gameStarted = false;
        
        private void Start()
        {
            // create the player and make the background white
            player = new Player(new Vector2(10, 10), new Vector2(15, 15), Color.Green, 30.0f);
            Raylib.ClearBackground(Color.White);
            _gameStarted = true;
        }

        private void Update()
        {

            // while the game should be running, update everything that should be updated, then clear the background and end drawing
            frameTime = Raylib.GetFrameTime();
                player.Update();

                Raylib.DrawText(Raylib.GetFPS().ToString(), 10, 10, 20, Color.Blue);
                Raylib.DrawText(frameTime.ToString(), 10, 30, 20, Color.Red);

                Raylib.ClearBackground(Color.White);
                Raylib.EndDrawing();

        }
        
        
        private void End()
        {
            
        }

        public void Run()
        {
            if (!_gameStarted)
                {
                Start();
                }
            Update();
            if (_gameOver)
            {
                End();
            }
        }
    }
}
