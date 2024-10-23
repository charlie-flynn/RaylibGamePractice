using Raylib_cs;
using System.Security.Cryptography.X509Certificates;

namespace RaylibGamePractice
{
    internal class Program
    {
        static void Main()
        {
             

            Raylib.InitWindow(550, 550, "game");
            Raylib.SetTargetFPS(60);
            Game game = new Game();

            while (!Raylib.WindowShouldClose())
            {
                
                game.Run();
                
            }
            Raylib.CloseWindow();
        }
    }
}
