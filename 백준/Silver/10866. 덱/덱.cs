using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace code
{
    class Program
    {

        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            LinkedList<int> deque = new LinkedList<int>();

            int N = int.Parse(sr.ReadLine());

            int num = 0;

            for (int i = 0; i < N; i++)
            {
                string[] line = sr.ReadLine().Split(' ');
                if (line.Length > 1)
                {
                    num = int.Parse(line[1]);
                }

                switch (line[0])
                {
                    case "push_front":
                        deque.AddFirst(num);
                        break;
                    case "push_back":
                        deque.AddLast(num);
                        break;
                    case "pop_front":
                        if (deque.Count > 0)
                        {
                            sb.AppendLine($"{deque.First.Value}");
                            deque.RemoveFirst();
                        }
                        else sb.AppendLine("-1");
                        break;
                    case "pop_back":
                        if (deque.Count > 0)
                        {
                            sb.AppendLine($"{deque.Last.Value}");
                            deque.RemoveLast();
                        }
                        else sb.AppendLine("-1");
                        break;
                    case "size":
                        sb.AppendLine($"{deque.Count}");
                        break;
                    case "empty":
                        sb.AppendLine($"{(deque.Count > 0 ? 0 : 1)}");
                        break;
                    case "front":
                        sb.AppendLine($"{(deque.Count > 0 ? deque.First.Value : -1)}");
                        break;
                    case "back":
                        sb.AppendLine($"{(deque.Count > 0 ? deque.Last.Value : -1)}");
                        break;
                }
            }

            sw.Write(sb.ToString());
            sw.Close();
            sr.Close();

        }
    }
}