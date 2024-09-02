using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder sb = new StringBuilder();
            int.TryParse(Console.ReadLine(), out int N);
            bool isOk = false;

            for(int i = 0; i < N; i++)
            {
                isOk = true;
                string line = Console.ReadLine();

                foreach(char c in line)
                {
                    if(c == '(') stack.Push(c);
                    else
                    {
                        if(stack.Count > 0 && stack.Peek() == '(') stack.Pop();
                        else
                        {
                            isOk = false;
                            break;
                        }
                    }
                }


                if(stack.Count == 0 && isOk) sb.AppendLine("YES");
                else sb.AppendLine("NO");
                stack.Clear();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}