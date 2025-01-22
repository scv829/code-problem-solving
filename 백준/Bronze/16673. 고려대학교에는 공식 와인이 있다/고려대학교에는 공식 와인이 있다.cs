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
            int result = 0;

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            for (int i = 1; i <= inputs[0]; i++)
            {
                result += i * inputs[1] + (int)Math.Pow(i, 2) * inputs[2];
            }

            sb.Append(result);


            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}