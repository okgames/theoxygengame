using System;
using System.Collections.Generic;
using System.Text;
using TheOxygenGame.View;
using TheOxygenGame.Model;
using TheOxygenGame.Controller;

namespace TheOxygenGame
{
    class Program
    { 
        public static int Main(string[] args)
        {
            var gameBoard = new GameBoardModel<int?>();
            var view = new ConsoleView<int?>();
            var controller = new GameBoardController<int?>(gameBoard);
            
            return 0;
        }    
    }
}
