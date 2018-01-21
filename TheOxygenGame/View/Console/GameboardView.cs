using System;
using System.Collections.Generic;
using System.Text;
using TheOxygenGame.Model;
using static System.Console;
using static System.Environment;

namespace TheOxygenGame.View.Console
{
    public class GameboardView<T> : IView<IGameBoardModel<T>>
    {
        public void Display(IGameBoardModel<T> gameboard)
        {
            Clear();
            for (int y = 0; y < gameboard.Width; y++)
            {
                for (int x = 0; x < gameboard.Height; x++)
                {
                    Write(string.Format("{0}\t", gameboard[y, x]?.ToString() ?? "X"));
                }
                Write(NewLine + NewLine + NewLine);
            }
        }
    }
}
