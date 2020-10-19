using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.DataStructures
{
    public class TwoDArray
    {
        private static readonly int[][] Arr = new int[6][];

        private static int SumHourGlass(int[] ints)
        {
            return ints.Sum();
        }

        private static int[] GetHourGlass(int i, int j)
        {
            //i j
            //0 0 -> 00 01 02 11 20 21 22
            //1 0 -> 01 02 03 12 21 22 23
            //2 0 -> 02 03 04 13 22 23 24
            //3 0
            //0 1 -> 10 11 12 21 30 31 32
            //1 1 -> 11 12 13 22 31 32 33
            //2 1
            //3 1
            int[] hg = new int[7];

            hg[0] = Arr[i][j];
            hg[1] = Arr[i][j + 1];
            hg[2] = Arr[i][j + 2];
            hg[3] = Arr[i + 1][j + 1];
            hg[4] = Arr[i + 2][j];
            hg[5] = Arr[i + 2][j + 1];
            hg[6] = Arr[i + 2][j + 2];

            return hg;
        }

        public static void Program(string[] args)
        {
            for (int arrI = 0; arrI < 6; arrI++)
            {
                string[] arrTemp = Console.ReadLine().Split(' ');
                Arr[arrI] = arrTemp.Select(int.Parse).ToArray();
            }

            int maxI = 4;
            int maxJ = 4;

            List<int> sumList = new List<int>();

            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                {
                    int[] hg = GetHourGlass(i, j);
                    int sum = SumHourGlass(hg);

                    sumList.Add(sum);
                }
            }

            Console.Write(sumList.Max());
        }
    }
}
