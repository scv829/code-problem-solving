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

            int t = int.Parse(sr.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                int U =  (inputs[1] * 2) - inputs[0];
                int T = inputs[1] - U;
                sb.AppendLine($"{U} {T}");
            }



            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}