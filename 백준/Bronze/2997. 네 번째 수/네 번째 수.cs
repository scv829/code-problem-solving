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
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            List<int> inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse).ToList();
            List<int> result = new List<int>();

            inputs.Sort();

            int d = Math.Min(inputs[1] - inputs[0], inputs[2] - inputs[1]);


            for(int i = 0; i < 4; i++)
            {
                result.Add(inputs[0] + d * i);
            }

            foreach(int num in result)
            {
                if (inputs.Contains(num)) continue;
                sb.Append(num);
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}