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
            int.TryParse(Console.ReadLine(), out int n);

            int[] number = new int[n];
            int count = 1;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                
                while(count <= num)
                {
                    stack.Push(count++);
                    sb.AppendLine("+");
                }

                if (stack.Contains(num))
                {
                    while (true)
                    {
                        int pop = stack.Pop();
                        sb.AppendLine("-");
                        if (pop == num)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    sb.Clear();
                    sb.Append("NO");
                    break;
                }
            }
            
            Console.Write(sb.ToString());
        }
    }
}
