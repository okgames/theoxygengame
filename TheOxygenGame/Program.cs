using System;
using System.Collections.Generic;
using System.Text;
using TheOxygenGame.View;
using TheOxygenGame.Model;
using TheOxygenGame.Controller;
using TheOxygenGame.View.Console;

namespace TheOxygenGame
{
    class Program
    { 

        private static void SplashScreen()
        {
            Console.WriteLine("The OXYGEN GAME");
            Console.WriteLine("You're inside the nuclear reactor. Use arrow keys to combine elements.");
            Console.WriteLine("Can you get OXYGEN?");
            Console.WriteLine("Press any key to start the game");
            Console.ReadKey(true);
        }

        public static int Main(string[] args)
        {
            Console.CursorVisible = false;
            SplashScreen();
            var gameBoard = new GameBoardModel();
            var viewFactory = new ConsoleViewFactory();
            var controller = new GameBoardController<int?>(gameBoard, viewFactory);

            while (true)
            {
                controller.GameKeyPressed(Console.ReadKey(true).Key);
            }
            return 0;
        }    
    }
}
