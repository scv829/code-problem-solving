using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace code
{
    class Program
    {
        static double answer;
        static Stack<int> buildingHeight = new Stack<int>();

        static void Main(string[] args)
        {
            answer = 0;

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int input = int.Parse(sr.ReadLine());
                IncreaseViewCount(input);
            }

            sb.Append($"{answer}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

        private static void IncreaseViewCount(int n)
        {
            while (buildingHeight.Count != 0 && buildingHeight.Peek() <= n)
            {
                buildingHeight.Pop();
            }
            answer += buildingHeight.Count;
            buildingHeight.Push(n);
        }
    }

}