using System;
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
            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            if (Math.Abs(inputs[0] - inputs[1]) >= inputs[2])
            {
                sb.Append((Math.Min(inputs[0], inputs[1]) + inputs[2]) * 2);
            }
            else if (inputs[0].Equals(inputs[1]))
            {
                inputs[2] -= (inputs[2] % 2 != 0) ? 1 : 0 ;
                 sb.Append((2 * inputs[0]) + inputs[2]);
            }else
            {
                inputs[2] -= Math.Abs(inputs[0] - inputs[1]);
                inputs[2] -= (inputs[2] % 2 != 0) ? 1 : 0;
                sb.Append((2 * Math.Max(inputs[0], inputs[1])) + inputs[2]);
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}