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


            while (true)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                if (input[0] == 0 && input[1] == 0) break;

                sb.AppendLine($"{input[0] + input[1]}");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
