using System;
using System.Collections.Generic;
using System.Text;
using TheOxygenGame.Model;

namespace TheOxygenGame.Controller
{
    public class GameBoardController
    {
        private IGameBoardModel<int> _gameBoard;

        public GameBoardController(IGameBoardModel<int> gameBoard)
        {
            _gameBoard = gameBoard;            
        }

        public void GameKeyPressed()
        {
            throw new NotImplementedException();
        }        
    }
}
