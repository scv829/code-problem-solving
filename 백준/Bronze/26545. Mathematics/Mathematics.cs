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

            int result = 0;

            for (int i = 0; i <N; i++)
            {
                result += int.Parse(sr.ReadLine());
            }

            sb.Append(result);

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
