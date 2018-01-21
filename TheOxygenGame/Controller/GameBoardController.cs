using System;
using System.Collections.Generic;
using System.Text;
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
            throw new NotImplementedException();
        }

    }
}
