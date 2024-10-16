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
        private void Start()
        {
            // initialize window, start drawing, create the player, make the background white
            Raylib.InitWindow(550, 550, "game");
            Raylib.BeginDrawing();
            Raylib.SetTargetFPS(60);
            player = new Player(new Vector2(10, 10), new Vector2(15, 15), Color.Green, 15.0f);
            Raylib.ClearBackground(Color.White);
        }

        private void Update()
        { 
            // while the game should be running, update everything that should be updated, then clear the background and end drawing
            while (!Raylib.WindowShouldClose() && !_gameOver)
            {
                frameTime = Raylib.GetFrameTime();
                player.Update();
                Raylib.DrawText(Raylib.GetFPS().ToString(), 10, 10, 20, Color.Blue);
                Raylib.DrawText(frameTime.ToString(), 10, 30, 20, Color.Red);
                Raylib.ClearBackground(Color.White);
                Raylib.EndDrawing();
                
            }

            // when the game isnt running, gmae over is true
            _gameOver = true;

        }
        
        
        private void End()
        {
            Raylib.CloseWindow();
        }

        public void Run()
        {
            Start();
            while (!_gameOver)
            {
                Update();
            }

            End();
        }
    }
}
