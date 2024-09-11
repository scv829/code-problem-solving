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

            Stack<char> goodWords = new Stack<char>();

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(sr.ReadLine());
            int count = 0;


            for (int i = 0; i < N; i++)
            {
                string line = sr.ReadLine();
                foreach (char c in line)
                {
                    if (goodWords.Count > 0)
                    {
                        if (goodWords.Peek() == c)
                        {
                            goodWords.Pop();
                        }
                        else
                        {
                            goodWords.Push(c);
                        }
                    }
                    else
                    {
                        goodWords.Push(c);
                    }
                }

                if (goodWords.Count == 0) count++;
                goodWords.Clear();
            }

            sb.Append(count);

            sw.Write(sb.ToString());
            sw.Close();
            sr.Close();
        }
    }
}
