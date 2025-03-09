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

            sr.ReadLine();

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            sb.Append(inputs.Max() - inputs.Min());

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}