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

            int result = 0;

            while(true)
            {
                int num = int.Parse(sr.ReadLine());

                if (num == -1) break;

                result += num;
            }

            sb.Append(result);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
