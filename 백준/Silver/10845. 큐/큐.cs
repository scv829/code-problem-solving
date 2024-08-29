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
            StringBuilder sb = new StringBuilder();

            Queue<int> queue = new Queue<int>();

            int.TryParse(Console.ReadLine(), out int N);

            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                switch (line[0])
                {
                    case "push":
                        int.TryParse(line[1], out int num);
                        queue.Enqueue(num);
                        break;
                    case "pop":
                        if (queue.Count > 0) sb.AppendLine($"{queue.Dequeue()}");
                        else sb.AppendLine("-1");
                        break;
                    case "size":
                        sb.AppendLine($"{queue.Count}");
                        break;
                    case "empty":
                        if (queue.Count > 0) sb.AppendLine("0");
                        else sb.AppendLine("1");
                        break;
                    case "front":
                        if (queue.Count > 0) sb.AppendLine($"{queue.First()}");
                        else sb.AppendLine("-1");
                        break;
                    case "back":
                        if (queue.Count > 0) sb.AppendLine($"{queue.Last()}");
                        else sb.AppendLine("-1");
                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
