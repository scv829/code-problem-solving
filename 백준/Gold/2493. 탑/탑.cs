using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            Stack<(int, int)> stack = new Stack<(int, int)>();

            int N = int.Parse(Console.ReadLine());
            string[] heights = Console.ReadLine().Split(' ');

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                while (stack.Count != 0 && stack.Peek().Item2 < int.Parse(heights[i]))
                    stack.Pop();
                if (stack.Count == 0) sb.Append(0 + " ");
                else sb.Append(stack.Peek().Item1 + " ");
                stack.Push((i + 1, int.Parse(heights[i])));
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
