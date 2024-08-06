using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            int.TryParse(Console.ReadLine(), out int K);
         
            for (int i = 0; i < K; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    if (stack.Count == 0) continue;
                    stack.Pop();
                } 
                else stack.Push(num);
            
            }
            sb.Append(stack.Sum());
            Console.WriteLine(sb.ToString());
        }
    }
}
