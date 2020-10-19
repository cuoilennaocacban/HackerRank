namespace Solution.DataStructures
{
    using System;
    using System.Collections.Generic;

    public class DynamicArray
    {
        private static int lastAns = 0;
        private static List<List<int>> segList;
        private static int N = 0;
        private static int _numberOfQueries = 0;

        public static void ReadInput(List<string[]> segments)
        {
            var arrTemp = Console.ReadLine().Split(' ');
            if (arrTemp.Length == 2)
            {
                //First Item
                N = int.Parse(arrTemp[0]);
                _numberOfQueries = int.Parse(arrTemp[1]);
            }

            //Read input
            for (int i = 0; i < _numberOfQueries; i++)
            {
                arrTemp = Console.ReadLine().Split(' ');
                segments.Add(arrTemp);
            }
        }

        private static void DoQuery1(int x, int y)
        {
            int index = ((x ^ lastAns) % N);
            segList[index].Add(y);
        }

        private static void DoQuery2(int x, int y)
        {
            int index = ((x ^ lastAns) % N);
            int size = segList[index].Count;
            lastAns = segList[index][y % size];
            Console.WriteLine(lastAns);
        }

        public static void Program(string[] args)
        {
            //Sample input
            //2 5
            //1 0 5
            //1 1 7
            //1 0 3
            //2 1 0
            //2 1 1

            List<string[]> segments = new List<string[]>();
            ReadInput(segments);

            segList = new List<List<int>>();
            for (int i = 0; i < N; i++)
            {
                var seg = new List<int>();
                segList.Add(seg);
            }

            foreach (string[] segment in segments)
            {
                if (segment[0] == "1")
                {
                    DoQuery1(int.Parse(segment[1]), int.Parse(segment[2]));
                }
                else
                {
                    DoQuery2(int.Parse(segment[1]), int.Parse(segment[2]));
                }
            }
        }
    }
}
