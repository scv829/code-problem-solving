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

            string line = "9780921418";
            int result = 0;

            for(int i = 0; i < line.Length; i++)
            {
                if (i % 2 == 0) result += (line[i] - '0') * 1;
                else result += (line[i] - '0') * 3;
            }

            int num1 = int.Parse(sr.ReadLine());
            int num2 = int.Parse(sr.ReadLine());
            int num3 = int.Parse(sr.ReadLine());

            result += num1 + num2 * 3 + num3;

            sb.Append($"The 1-3-sum is {result}");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}