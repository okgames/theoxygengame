using System;
using System.Collections.Generic;
using System.Text;

namespace TheOxygenGame.Model
{
    public class GameBoardModel: IGameBoardModel<int?>
    {
        public int? this[int x, int y] => throw new NotImplementedException();
        public int Width => throw new NotImplementedException();
        public int Height => throw new NotImplementedException();

        public void Move(string direction)
        {
            throw new NotImplementedException();
        }

        public bool MovePossible()
        {
            throw new NotImplementedException();
        }
    }
}
