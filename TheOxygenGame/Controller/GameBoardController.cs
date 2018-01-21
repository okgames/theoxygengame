using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TheOxygenGame.Model;
using TheOxygenGame.View;

namespace TheOxygenGame.Controller
{
    public class GameBoardController<T>
    {
        private IGameBoardModel<T> _gameBoard;
        private IViewFactory _viewFactory;

        public GameBoardController(IGameBoardModel<T> gameBoard, IViewFactory viewFactory)
        {
            _gameBoard = gameBoard;
            _viewFactory = viewFactory;
        }        

        public void GameKeyPressed(ConsoleKey key)
        {
            Direction direction = Direction.Up;
            bool movementKeyPressed = true;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    direction = Direction.Down;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    direction = Direction.Right;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    direction = Direction.Left;
                    break;
                default:
                    movementKeyPressed = false;
                    break;
            }
            if (movementKeyPressed)
            {
                _gameBoard.Move(direction);
                _viewFactory.GameboardView<T>().Display(_gameBoard);
                if (!_gameBoard.MovePossible())
                {
                    _viewFactory.MessageView().Display("You have lost. Press ESC to exit");
                }
            }
            if (key == ConsoleKey.Escape)
            {
                _viewFactory.MessageView().Display("Thank you for playing. Bye");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }

    }
}
