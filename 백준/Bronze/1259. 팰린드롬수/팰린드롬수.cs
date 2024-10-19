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

            bool isOk;

            while (true)
            {
                string input = sr.ReadLine();
                isOk = true;

                if (input == "0") break;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[(input.Length - 1) - i] != input[i])
                    {
                        isOk = false;
                        break;
                    }
                }
                sb.AppendLine($"{((isOk) ? "yes" : "no")}");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
