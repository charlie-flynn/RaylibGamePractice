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
        public float timer;
        private bool _gameOver = false;
        Player player;
        private void Start()
        {
            // initialize window, start drawing, create the player, make the background white
            Raylib.InitWindow(550, 550, "game");
            Raylib.BeginDrawing();
            Raylib.SetTargetFPS(60);
            player = new Player(new Vector2(10, 10), new Vector2(15, 15), Color.Green, 10.0f);
            Raylib.ClearBackground(Color.White);
        }

        private void Update()
        {
            // every single updatable thing goes in here

            
            // while the game should be running, update everything that should be updated, then clear the background and end drawing
            while (!Raylib.WindowShouldClose() && !_gameOver)
            {
                timer = Raylib.GetFrameTime();
                player.Update();
                Raylib.DrawText(Raylib.GetFPS().ToString(), 10, 10, 20, Color.Blue);
                Raylib.DrawText(timer.ToString(), 10, 30, 20, Color.Red);
                Raylib.ClearBackground(Color.White);
                Raylib.EndDrawing();
                
            }
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
