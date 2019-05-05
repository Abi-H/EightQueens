/*****************************************
*   Solution to the Eight Queens problem *
*   by Abi Harper                        *
****************************************/

using System;

namespace EightQueens
{
    public class Program
    {
        static void Main()
        {
            int n = 8;
            int[,] solution = new int[8, 8];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    solution[i, j] = 0;
                }
            }

            Solve(solution, n);
            Console.ReadKey();
        }

        public static void Solve(int[,] solution, int n)
        {
            if (PlaceQueens(solution, 0, n))
            {
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(" " + solution[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No possible solution");
            }
        }

        public static bool PlaceQueens(int[,] solution, int queen, int n)
        {
            if (queen == n)
                return true;

            for (int row = 0; row < n; row++)
            {
                if (CanPlace(solution, row, queen))
                {
                    solution[row, queen] = 1;

                    if (PlaceQueens(solution, queen + 1, n))
                        return true;

                    solution[row, queen] = 0;
                }
            }
            return false;
        }



        public static bool CanPlace(int[,] solution, int row, int col)
        {
            int r;
            int c;
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0)
                        continue;

                    r = row;
                    c = col;

                    while (r >= 0 && r <= solution.GetUpperBound(0) && c >= 0 && c <= solution.GetUpperBound(1))
                    {
                        if (solution[r, c] == 1)
                            return false;

                        r += y;
                        c += x;
                    }
                }
            }
            return true;
        }
    }
}


