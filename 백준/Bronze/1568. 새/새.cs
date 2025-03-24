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

            int num = 1;

            while(N > 0)
            {
                if (N - num >= 0)
                {
                    N -= num++;
                    result++;
                }
                else
                {
                    num = 1;
                }
            }

            sb.Append(result);


            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}