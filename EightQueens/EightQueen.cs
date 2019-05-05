/*****************************************
*   Solution to the Eight Queens problem *
*   by Abi Harper                        *
****************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueens
{
    class EightQueen
    {
        public int Size { get; set; }
        public EightQueen(int size)
        {
            this.Size = size;
        }
        public void GetSolution()
        {
            int line = 0, pos = -1, count = 0;
            int[] positions = new int[Size];

            for (int m = 0; m < positions.Length; m++)
                positions[m] = -1;

            while (true)
            {
                for (pos = positions[line] + 1; pos < Size; pos++)
                {
                    int i = 0;
                    for (i = 0; i < line; i++)
                    {
                        int dis = line - i;
                        if (positions[i] == pos || positions[i] == pos + dis || positions[i] == pos - dis)
                            break;
                    }
                    if (i == line)
                    {
                        positions[line] = pos;
                        line++;
                        if (line == Size)
                        {
                            count++;
                            Console.WriteLine(count);
                            foreach (int item in positions)
                            {
                                for (int j = 0; j < Size; j++)
                                {
                                    if (j == item)
                                        Console.Write("Q ");
                                    else
                                        Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                            line--;
                        }
                        else
                            break;
                    }
                }
                if (pos == Size)
                {
                    if (line == 0)
                    {
                        Console.WriteLine("Over");
                        break;
                    }
                    else
                    {
                        positions[line] = -1;
                        line--;
                    }
                }
            }
        }
    }
}
