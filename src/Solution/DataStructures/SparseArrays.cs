namespace Solution.DataStructures
{
    using System;

    public class SparseArrays
    {
        private static int _stringNumber;

        private static int _queriesNumber;

        private static string[] _strings;

        private static string[] _queries;

        public static void ReadInput()
        {
            _stringNumber = int.Parse(Console.ReadLine());

            _strings = new string[_stringNumber];

            for (int i = 0; i < _stringNumber; i++)
            {
                _strings[i] = Console.ReadLine();
            }

            _queriesNumber = int.Parse(Console.ReadLine());

            _queries = new string[_queriesNumber];

            for (int i = 0; i < _queriesNumber; i++)
            {
                _queries[i] = Console.ReadLine();
            }
        }

        public static void Program(string[] args = null)
        {
            ReadInput();
            Solve();
        }

        public static void Solve()
        {
            for (int i = 0; i < _queriesNumber; i++)
            {
                int repeat = 0;
                for (int j = 0; j < _stringNumber; j++)
                {
                    if (string.Equals(_queries[i], _strings[j]))
                    {
                        repeat++;
                    }
                }
                Console.WriteLine(repeat);
            }
        }
    }
}
