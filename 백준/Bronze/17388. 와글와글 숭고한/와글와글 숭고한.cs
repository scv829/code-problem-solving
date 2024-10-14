using System;
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

            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            if (input[0] + input[1] + input[2] >= 100) sb.Append("OK");
            else
            {
                int num = Math.Min(Math.Min(input[0], input[1]), input[2]);
                int index = 0;
                foreach (int i in input) { if (i == num) { break; } index++; }

                sb.Append($"{ ( (index == 0) ? "Soongsil" : ((index == 1) ? "Korea" : "Hanyang") ) }");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
