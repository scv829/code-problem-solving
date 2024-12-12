using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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


            List<int>[] outputs = new List<int>[10];

            for(int i = 0; i < 9; i++)
            {
                outputs[i] = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse).ToList();
            }

            int result = 0;

            int x = 0;
            int y = 0;

            for (int i = 0; i < 9; i++) 
            {
                if( result <= outputs[i].Max())
                {
                    result = outputs[i].Max();
                    x = outputs[i].IndexOf(result) + 1;
                    y = i + 1;
                }
            }

            sb.AppendLine($"{result}");
            sb.AppendLine($"{y} {x}");
            

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
