using System;
using System.Collections.Generic;
using System.Text;

namespace TheOxygenGame.Model
{
    public class GameBoardModel: IGameBoardModel<int?>
    {
        private int[,] arr;

        public int? this[int x, int y] => throw new NotImplementedException();
        public int Width => throw new NotImplementedException();
        public int Height => throw new NotImplementedException();

        public GameBoardModel()
        {

        }

        public void Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        public bool MovePossible()
        {
            return false;
        }
    }
}
