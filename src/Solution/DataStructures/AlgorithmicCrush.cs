namespace Solution.DataStructures
{
    using System;
    using System.Linq;

    class AlgorithmicCrush
    {
        private static int[] result;

        private static int N = 0;
        private static int _numberOfQueries = 0;

        private static void DoOperation(int a, int b, int k)
        {
            for (int i = a-1; i < b; i++)
            {
                result[i] = result[i] + k;
            }
        }

        public static void Program(string[] args = null)
        {
            var arrTemp = Console.ReadLine().Split(' ');
            if (arrTemp.Length == 2)
            {
                //First Item
                N = int.Parse(arrTemp[0]);
                _numberOfQueries = int.Parse(arrTemp[1]);
            }

            result = new int[N];

            //Read input
            for (int i = 0; i < _numberOfQueries; i++)
            {
                arrTemp = Console.ReadLine().Split(' ');
                DoOperation(int.Parse(arrTemp[0]), int.Parse(arrTemp[1]), int.Parse(arrTemp[2]));
            }

            Console.WriteLine(result.Max());
            Console.ReadLine();
        }
    }
}