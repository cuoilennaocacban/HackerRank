namespace Solution.DataStructures
{
    using System;

    public class LeftRotation
    {
        private static int _arraySize;
        private static int _d;

        private static int[] _array;

        public static void ReadInput()
        {
            var tempArray = Console.ReadLine().Split(' ');
            if (tempArray.Length == 2)
            {
                //First Item
                _arraySize = int.Parse(tempArray[0]);
                _d = int.Parse(tempArray[1]);
            }

            _array = new int[_arraySize];

            tempArray = Console.ReadLine().Split(' ');

            //Read input
            for (int i = 0; i < _arraySize; i++)
            {
                _array[i] = int.Parse(tempArray[i]);
            }
        }

        public static void Program(string[] args = null)
        {
            Solve();
        }

        public static void Solve()
        {
            ReadInput();

            int rotate = _d % _arraySize;

            for (int i = rotate; i < _arraySize; i++)
            {
                Console.Write(_array[i] + " ");
            }

            for (int i = 0; i < rotate; i++)
            {
                Console.Write(_array[i] + " ");
            }
        }
    }
}
