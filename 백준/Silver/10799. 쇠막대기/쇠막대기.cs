using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace code
{
    class Program
    {
        static double answer;

        static void Main(string[] args)
        {

            Stack<char> pipes = new Stack<char>();

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            string input = sr.ReadLine();
            int floor = 0;
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == '(')
                {
                    if (pipes.Count > 0 && pipes.Peek() == '(')
                    {
                        floor++;
                    }
                }
                else
                {
                    if (pipes.Peek() == '(')
                    {
                        result += floor;
                    }
                    else
                    {
                        floor--;
                        result++;
                    }
                }
                pipes.Push(c);
            }

            sb.AppendLine($"{result}");

            sw.Write(sb.ToString());
            sw.Close();
            sr.Close();
        }
    }
}
