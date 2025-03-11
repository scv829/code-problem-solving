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
            int digit = 1;

            while(true)
            {
                if (N / ((int)Math.Pow(10, (digit))) == 0) 
                {
                    result += (N - ((int)Math.Pow(10, (digit - 1))) + 1 ) * digit;
                    break;
                }
                else
                {
                    result += (((int)Math.Pow(10, (digit)) - 1) - (int)Math.Pow(10, (digit - 1)) + 1 ) * digit;
                    digit++;
                }
            }

            sb.Append(result);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}