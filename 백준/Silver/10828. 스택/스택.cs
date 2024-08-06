using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int count = 0;
            StringBuilder sb = new StringBuilder();
            int.TryParse(Console.ReadLine(), out int N);
            

            for (int i = 0; i < N; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                switch (command[0])
                {
                    case "push":
                        stack.Push(int.Parse(command[1]));
                        count++;
                        break;
                    case "pop":
                        if (count == 0) sb.Append(-1);
                        else { sb.Append(stack.Pop()); count--; }
                        break;
                    case "size":
                        Console.WriteLine(count);
                        break;
                    case "empty":
                        if (count == 0) sb.Append(1);
                        else sb.Append(0);
                        break;
                    case "top":
                        if (count == 0) sb.Append(-1);
                        else sb.Append(stack.Peek());
                        break;
                }
                if(sb.Length != 0)Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }
    }
}
