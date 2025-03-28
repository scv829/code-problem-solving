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

            List<int> list = new List<int>();

            int N = int.Parse(sr.ReadLine());
            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            list.Add(1);

            for (int i = 2; i <= N; i++)
            {
                list.Insert(list.Count - inputs[i - 1], i);
            }

            foreach (int num in list)
            {
                sb.Append($"{num} ");
            }


            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}