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

            foreach (char c in sr.ReadLine())
            {
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        result++;
                        break;
                    default:
                        break;
                }
            }
            sb.Append(result);

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
