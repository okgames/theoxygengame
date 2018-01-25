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
        private static Dictionary<string, string> map = new Dictionary<string, string>()
        {
            { "X", "#" },
            { "2", "H" },
            { "4", "He" },
            { "8", "Li" },
            { "16", "Be" },
            { "32", "B" },
            { "64", "N" },
            { "128", "O" },
            { "256", "F" },
            { "512", "Ne" },
            { "1024", "Na" },
            { "2048", "Mg" }
        };

        public void Display(IGameBoardModel<T> gameboard)
        {
            Clear();
            for (int y = 0; y < gameboard.Width; y++)
            {
                for (int x = 0; x < gameboard.Height; x++)
                {
                    var z = gameboard[y, x]?.ToString() ?? "X";
                    var h = "";
                    if (map.TryGetValue(z, out h))
                    {
                        z = h;
                    }
                    Write(string.Format("{0}\t", h));
                }
                Write(NewLine + NewLine + NewLine);
            }
        }
    }
}
