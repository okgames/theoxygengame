using System;
using System.Collections.Generic;
using System.Text;

namespace TheOxygenGame.Model
{
    public class GameBoardModel<T> : IGameBoardModel<T>
    {
        public T this[int x, int y] => throw new NotImplementedException();
        public int Width => throw new NotImplementedException();
        public int Height => throw new NotImplementedException();
        public event EventHandler<IGameBoardModel<T>> StateChanged;
        public void Merge(string direction)
        {
            throw new NotImplementedException();
        }
        public bool MoveAvailable()
        {
            throw new NotImplementedException();
        }
    }
}
