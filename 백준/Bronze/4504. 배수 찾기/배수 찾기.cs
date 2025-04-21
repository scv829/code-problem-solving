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

            int N = int.Parse(sr.ReadLine());

            while (true)
            {
                int num = int.Parse(sr.ReadLine());

                if (num == 0) break;

                sb.Append($"{num} is ");
                if (num % N != 0) sb.Append("NOT ");
                sb.Append($"a multiple of {N}.\n");
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}