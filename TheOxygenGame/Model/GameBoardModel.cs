using System;
using System.Collections.Generic;
using System.Text;

namespace TheOxygenGame.Model
{
    public class GameBoardModel : IGameBoardModel<int?>
    {
        private int?[,] arr;
        private static Random rnd = new Random();
        private static int? baseValue = 2;

        public int? this[int x, int y] => arr[x, y];
        public int Width { get; private set; }
        public int Height { get; private set; }

        public GameBoardModel(int width = 4, int height = 4)
        {
            arr = new int?[width, height];
            Width = width;
            Height = height;
            Init();
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    MergeDown();
                    break;
                case Direction.Up:
                    MergeUp();
                    break;
                case Direction.Left:
                    MergeLeft();
                    break;
                case Direction.Right:
                    MergeRight();
                    break;
            }
            NewTile();
        }

        public bool MovePossible()
        {
            for (int j = 0; j < Height; j++)
                for (int i = 0; i < Width; i++)
                    if (arr[i, j] == null ||
                        (j < Height - 1 && arr[i, j] == arr[i, j + 1]) ||
                        (i < Width - 1 && arr[i, j] == arr[i + 1, j]))
                        return true;
            return false;
        }

        private void Init()
        {
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    arr[i, j] = null;
        }

        private void NewTile()
        {
            var availableTiles = new List<int[]>();
            int Width = arr.GetLength(0);
            int Height = arr.GetLength(1);
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    if (arr[i, j] == null)
                        availableTiles.Add(new[] { i, j });
            if (availableTiles.Count == 0)
                return;
            var n = rnd.Next(availableTiles.Count);
            arr[availableTiles[n][0], availableTiles[n][1]] = baseValue;
        }

        private void MoveDown()
        {
            var x = Height - 1;

            while (x >= 0)
            {
                for (var j = 0; j < Width; j++)
                {
                    if (arr[x, j] == null)
                    {
                        var i = x;
                        while (i > 0 && arr[--i, j] == null) ;
                        arr[x, j] = arr[i, j];
                        arr[i, j] = null;
                    }
                }
                x--;
            }
        }

        private void JoinDown()
        {
            var x = Height - 1;

            while (x > 0)
            {
                for (var j = 0; j < Width; j++)
                {
                    if (arr[x, j] != null)
                    {
                        if (arr[x - 1, j] == arr[x, j])
                        {
                            arr[x, j] = arr[x, j] * baseValue;
                            arr[x - 1, j] = null;
                        }
                    }
                }
                x--;
            }
        }

        private void MergeDown()
        {
            MoveDown();
            JoinDown();
            MoveDown();
        }

        private void MoveUp()
        {
            var x = 0;

            while (x < Height)
            {
                for (var j = 0; j < Width; j++)
                {
                    if (arr[x, j] == null)
                    {
                        var i = x;
                        while (i < Height - 1 && arr[++i, j] == null) ;
                        arr[x, j] = arr[i, j];
                        arr[i, j] = null;
                    }
                }
                x++;
            }
        }

        private void JoinUp()
        {
            var x = 0;

            while (x < Height - 1)
            {
                for (var j = 0; j < Width; j++)
                {
                    if (arr[x, j] != null)
                    {
                        if (arr[x + 1, j] == arr[x, j])
                        {
                            arr[x, j] = arr[x, j] * baseValue;
                            arr[x + 1, j] = null;
                        }
                    }
                }
                x++;
            }
        }

        private void MergeUp()
        {
            MoveUp();
            JoinUp();
            MoveUp();
        }

        private void MoveLeft()
        {
            var x = 0;

            while (x < Width)
            {
                for (var j = 0; j < Height; j++)
                {
                    if (arr[j, x] == null)
                    {
                        var i = x;
                        while (i < Width - 1 && arr[j, ++i] == null) ;
                        arr[j, x] = arr[j, i];
                        arr[j, i] = null;
                    }
                }
                x++;
            }
        }

        private void JoinLeft()
        {
            var x = 0;

            while (x < Width - 1)
            {
                for (var j = 0; j < Height; j++)
                {
                    if (arr[j, x] != null)
                    {
                        if (arr[j, x + 1] == arr[j, x])
                        {
                            arr[j, x] = arr[j, x] * baseValue;
                            arr[j, x + 1] = null;
                        }
                    }
                }
                x++;
            }
        }

        private void MergeLeft()
        {
            MoveLeft();
            JoinLeft();
            MoveLeft();
        }

        private void MoveRight()
        {
            var x = Width - 1;

            while (x >= 0)
            {
                for (var j = 0; j < Height; j++)
                {
                    if (arr[j, x] == null)
                    {
                        var i = x;
                        while (i > 0 && arr[j, --i] == null) ;
                        arr[j, x] = arr[j, i];
                        arr[j, i] = null;
                    }
                }
                x--;
            }
        }

        private void JoinRight()
        {
            var x = Width - 1;

            while (x > 0)
            {
                for (var j = 0; j < Height; j++)
                {
                    if (arr[j, x] != null)
                    {
                        if (arr[j, x - 1] == arr[j, x])
                        {
                            arr[j, x] = arr[j, x] * baseValue;
                            arr[j, x - 1] = null;
                        }
                    }
                }
                x--;
            }
        }

        private void MergeRight()
        {
            MoveRight();
            JoinRight();
            MoveRight();
        }

    }
}

