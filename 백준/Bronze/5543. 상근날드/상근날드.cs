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

            int[] burgers = new int[3];

            int result = 99999;

            for (int i = 0; i < 3; i++)
            {
                burgers[i] = int.Parse(sr.ReadLine());
            }

            for (int i = 0; i < 2; i++)
            {
                int juice = int.Parse(sr.ReadLine());

                foreach (int b in burgers)
                {
                    result = Math.Min(result, b + juice - 50);
                }
            }
            sb.Append(result);

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
