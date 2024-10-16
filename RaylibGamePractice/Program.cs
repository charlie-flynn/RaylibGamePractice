using Raylib_cs;
using System.Security.Cryptography.X509Certificates;

namespace RaylibGamePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Raylib.InitWindow(550, 550, "game");
            Raylib.BeginDrawing();
            Raylib.SetTargetFPS(60);
            Game game = new Game();

            while (!Raylib.WindowShouldClose())
            {
                float frameTime = Raylib.GetFrameTime();
                game.Run();
            }
            Raylib.CloseWindow();
        }
    }
}
