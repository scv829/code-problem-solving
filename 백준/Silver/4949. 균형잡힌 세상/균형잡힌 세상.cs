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

            while (true)
            {
                string line = Console.ReadLine();

                if (line == ".") break;
                else
                {
                    foreach (char c in line)
                    {
                        if (c == '[' || c == '(')
                        {
                            stack.Push(c);
                        }
                        else if (c == ']')
                        {
                            if (stack.Count > 0 && stack.Peek() == '[') { stack.Pop(); }
                            else { sb.AppendLine("no"); break; }
                        }
                        else if (c == ')')
                        {
                            if (stack.Count > 0 && stack.Peek() == '(') { stack.Pop(); }
                            else { sb.AppendLine("no"); break; }
                        }
                        else if (c == '.')
                        {
                            if (stack.Count == 0) sb.AppendLine("yes");
                            else sb.AppendLine("no");
                        }
                    }
                }
                stack.Clear();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
