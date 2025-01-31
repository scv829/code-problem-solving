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

            if (12 <= inputs[0] && inputs[0] <= 16 && inputs[1] == 0) sb.Append("320");
            else sb.Append("280");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}