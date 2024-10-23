using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using System.Reflection.Metadata;
using MathLibrary;
using System.Security.Cryptography.X509Certificates;

namespace RaylibGamePractice
{
    public class Game
    {
        private bool _gameOver = false;
        Player player;
        private void Start()
        {
            // create the player and make the background white
            player = new Player(new Vector2(10, 10), new Vector2(15, 15), Color.Green, 150.0f);
            Raylib.ClearBackground(Color.White);
            Raylib.BeginDrawing();
        }

        private void Update()
        {
                Raylib.BeginDrawing();
            
                player.Update();

                Raylib.DrawText(Raylib.GetFPS().ToString(), 10, 10, 20, Color.Blue);
                Raylib.DrawText(Raylib.GetFrameTime().ToString(), 10, 30, 20, Color.Red);

                Raylib.ClearBackground(Color.White);
                Raylib.EndDrawing();
        }
        
        
        private void End()
        {
            
        }

        public void Run()
        {
            Start();
            while (!Raylib.WindowShouldClose() && !_gameOver)
            {
                Update();
            }
            End();
        }
    }
}
