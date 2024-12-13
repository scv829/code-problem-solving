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


            while(true)
            {
                string input = sr.ReadLine();

                if (input.Equals("*")) break;

                string line = new string(input.Replace(" ", string.Empty).Distinct().ToArray());

                sb.AppendLine($"{(line.Length.Equals(26) ? "Y" : "N")}");
            }

            
            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
