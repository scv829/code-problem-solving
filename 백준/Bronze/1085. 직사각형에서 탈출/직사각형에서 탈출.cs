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

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            List<double> pos = new List<double>()
            {
                (inputs[3] - inputs[1]),
                (inputs[2] - inputs[0]),
                (inputs[1]),
                (inputs[0]),
            };

            sb.Append(pos.Min());

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}