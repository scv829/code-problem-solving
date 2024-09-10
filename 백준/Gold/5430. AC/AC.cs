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
            LinkedList<int> deque = new LinkedList<int>();

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int T = int.Parse(sr.ReadLine());

            for (int i = 0; i < T; i++)
            {

                string command = sr.ReadLine();
                int n = int.Parse(sr.ReadLine());
                string line = sr.ReadLine();
                int[] ints = (line.Length > 2) ?
                    Array.ConvertAll(line.Substring(1, line.Length - 2).Split(','), int.Parse)
                    : new int[0];
                bool isRight = true;
                bool isError = false;

                foreach (int num in ints) deque.AddLast(num);

                foreach (char c in command)
                {
                    if (c == 'D')
                    {
                        if (deque.Count > 0)
                        {
                            if (isRight) deque.RemoveFirst();
                            else deque.RemoveLast();
                        }
                        else
                        {
                            isError = true;
                            break;
                        }
                    }
                    else
                    {
                        isRight = !isRight;
                    }
                }

                if (isError)
                {
                    sb.AppendLine("error");
                }
                else
                {
                    sb.AppendLine(ReturnArray(deque, isRight));
                }

                deque.Clear();
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

        static string ReturnArray(LinkedList<int> deque, bool isRight)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            if (deque.Count == 0)
            {
                sb.Append($"]");
                return sb.ToString();
            }

            if (isRight)
            {
                for (LinkedListNode<int> node = deque.First; node != deque.Last; node = node.Next)
                {
                    sb.Append($"{node.Value},");
                }
            }
            else
            {
                for (LinkedListNode<int> node = deque.Last; node != deque.First; node = node.Previous)
                {
                    sb.Append($"{node.Value},");
                }
            }
            sb.Append($"{(isRight ? deque.Last.Value : deque.First.Value)}]");
            return sb.ToString();
        }
    }

}