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

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            Dictionary<string, string> pocketmonDic = new Dictionary<string, string>();
            Dictionary<int, string> nameDic = new Dictionary<int, string>();

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < inputs[0]; i++)
            {
                string input = sr.ReadLine();
                pocketmonDic.Add(input, $"{i + 1}");
                pocketmonDic.Add($"{i + 1}", input);
            }

            for (int i = 0; i < inputs[1]; i++)
            {
                sb.AppendLine(pocketmonDic[sr.ReadLine()]);
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}