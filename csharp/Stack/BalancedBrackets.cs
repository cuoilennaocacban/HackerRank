namespace Solution.Stack
{
    using System;
    using System.Collections.Generic;

    public class BalancedBrackets
    {
        private static int _n;

        public static bool IsMatch(char a, char b)
        {
            bool result = false;

            switch (a)
            {
                case '[':
                case ']':
                    {
                        if ((a + b) == 184)
                        {
                            return true;
                        }
                        break;
                    }
                case '{':
                case '}':
                    {
                        if ((a + b) == 248)
                        {
                            return true;
                        }
                        break;
                    }
                case '(':
                case ')':
                    {
                        if ((a + b) == 81)
                        {
                            return true;
                        }
                        break;
                    }
            }

            return result;
        }

        public static int ReadNumber(string s)
        {
            return int.Parse(s);
        }

        public static void Program(string[] args = null)
        {
            _n = ReadNumber(Console.ReadLine());

            for (int i = 0; i < _n; i++)
            {
                string temp = Console.ReadLine();
                int len = temp.Length;
                if (len % 2 != 0)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                bool exitLoop = false;

                for (int j = 1; j < len; j++)
                {
                    // switch (temp[j])
                    // {
                    //     //TODO:
                    // }

                    if (exitLoop)
                    {
                        break;
                    }
                }
            }
        }
    }
}