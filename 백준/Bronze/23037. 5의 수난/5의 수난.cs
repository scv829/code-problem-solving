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

            string input = sr.ReadLine();

            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result += Math.Pow((input[i] - '0'), 5);
            }
            sb.Append(result);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
