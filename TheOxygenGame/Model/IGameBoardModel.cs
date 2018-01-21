using System;
using System.Collections.Generic;

namespace TheOxygenGame.Model
{
    public interface IGameBoardModel<T>
    {
        T this[int x, int y] { get; }
        int Width { get; }
        int Height { get; }

        void Merge(string direction);
        bool MoveAvailable();
    }
}