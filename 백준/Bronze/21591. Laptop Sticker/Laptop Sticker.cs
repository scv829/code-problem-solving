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

            sb.Append((inputs[0] >= inputs[2] + 2 && inputs[1] >= inputs[3] + 2) ? "1" : "0");


            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}