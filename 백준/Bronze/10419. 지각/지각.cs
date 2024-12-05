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

            int T = int.Parse(sr.ReadLine());

            // a + b = 1
            // a * b = d

            for (int i = 0; i < T; i++) 
            { 
                int d = int.Parse(sr.ReadLine());
                for(int j = 0; j < 10001; j++)
                {
                    if( (j + (j*j) > d ))
                    {
                        sb.AppendLine($"{j - 1}");
                        break;
                    }
                }
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}