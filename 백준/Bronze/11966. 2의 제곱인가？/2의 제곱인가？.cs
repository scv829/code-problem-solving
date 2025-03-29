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
                if (N == 1)
                {
                    sb.Append(1);
                    break;
                }
                else
                {
                    if (N % 2 == 1)
                    {
                        sb.Append(0);
                        break;
                    }
                    else
                    {
                        N /= 2;
                    }
                }

            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}