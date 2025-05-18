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

            List<long> inputs = Array.ConvertAll(sr.ReadLine().Split(' '), long.Parse).ToList();

            inputs.Sort();

            sb.Append((inputs[0] + inputs[1]) * (inputs[1] - inputs[0] + 1) * 0.5);

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
