using System;
using System.Collections.Generic;
using System.Text;

namespace TheOxygenGame.Model
{
    public interface IGameBoardModel
    {
        ICollection<ICollection<int>> GameBoard { get; }

        void Merge(string direction);
        bool MoveAvailable();
    }
}
