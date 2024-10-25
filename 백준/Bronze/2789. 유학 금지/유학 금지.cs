using System;
using System.IO;
using System.Linq;
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

            string input = sr.ReadLine();

            foreach (char c in input)
            {
                if (!"CAMBRIDGE".Contains(c))
                {
                    sb.Append(c);
                }
            }



            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}