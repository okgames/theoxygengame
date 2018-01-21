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
        public static int Main(string[] args)
        {
            var gameBoard = new GameBoardModel();
            var viewFactory = new ConsoleViewFactory();
            var controller = new GameBoardController<int?>(gameBoard, viewFactory);
            Console.CursorVisible = false;
            while (true)
            {
                controller.GameKeyPressed(Console.ReadKey(true).Key);
            }
            return 0;
        }    
    }
}
