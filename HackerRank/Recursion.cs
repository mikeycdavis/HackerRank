using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public static class Recursion
    {
        public static int GCD(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }

            return x > y ? GCD(x % y, y) : GCD(x, y % x);
        }

        public static int Fibonacci(int x)
        {
            // Fill Up this function body
            // You can add another function as well, if required///
            return FibonacciRecursion(1, 0, 3, x);
        }

        private static int FibonacciRecursion(int last, int secondLast, int n, int terminate)
        {
            if (n == terminate)
            {
                return last + secondLast;
            }

            return FibonacciRecursion(last + secondLast, last, n + 1, terminate);
        }

        public static List<string> PascalTriangle(int row)
        {
            List<string> result = new List<string>();

            for (int rowIndex = 0; rowIndex < row; rowIndex++)
            {
                result.Add(GetPascalTriangleRow(rowIndex + 1));
            }

            return result;
        }

        private static string GetPascalTriangleRow(int row)
        {
            return string.Empty;
        }
    }
}
