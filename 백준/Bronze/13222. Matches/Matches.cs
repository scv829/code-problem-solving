using System;
using System.IO;
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

            for(int i = 0; i < inputs[0]; i++)
            {
                int input = int.Parse(sr.ReadLine());
                sb.AppendLine($"{((Math.Pow(input, 2) <= (Math.Pow(inputs[1],2) + Math.Pow(inputs[2], 2))) ? "YES" : "NO")}");
            }


            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
