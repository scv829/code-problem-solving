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

            int N = int.Parse(sr.ReadLine());
            int result = 0;
            
            for(int i = 0; i < N; i++)
            {
                int input = int.Parse(sr.ReadLine());

                for (int j = 1; (2 * j) - 1 <= input; j++)
                {
                    result += (2 * j) - 1;
                }

                sb.AppendLine($"{result}");
                result = 0;
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
