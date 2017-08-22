namespace Solution.Stack
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Element
    {
        public int MaxValue { get; set; }
        public int PreviousMax { get; set; }
    }

    public class MaximumElement
    {
        private static int _n;

        private static System.Collections.Generic.Stack<Element> _stack;

        public static int ReadNumber(string s)
        {
            return int.Parse(s);
        }

        public static void Program(string[] args = null)
        {
            _n = ReadNumber(Console.ReadLine());

            _stack = new Stack<Element>();

            int max = 0;

            for (int i = 0; i < _n; i++)
            {
                var temp = Console.ReadLine().Split(' ');
                switch (temp[0])
                {
                    case "1":
                    {
                        Element e = new Element();
                        e.MaxValue = ReadNumber(temp[1]);
                        if(max <= e.MaxValue)
                        {
                            e.PreviousMax = max;
                            max = e.MaxValue;
                        }
                        _stack.Push(e);
                        break;
                    }
                    case "2":
                    {
                        Element e = _stack.Pop();
                        if(e.MaxValue == max)
                        {
                            max = e.PreviousMax;
                        }
                        break;
                    }
                    case "3":
                        Console.WriteLine(max);
                        break;
                }
            }
        }
    }
}