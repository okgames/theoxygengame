using System;
using System.Collections.Generic;
using System.Text;
using TheOxygenGame.Model;

namespace TheOxygenGame.Controller
{
    public class GameBoardController<T>
    {
        private IGameBoardModel<T> _gameBoard;

        public GameBoardController(IGameBoardModel<T> gameBoard)
        {
            _gameBoard = gameBoard;            
        }

        public void GameKeyPressed()
        {
            throw new NotImplementedException();
        }
    }
}
