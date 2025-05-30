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

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            char[] alpha = new char[] { 'I', 'O','S', 'H', 'Z', 'X', 'N' };
            string input = sr.ReadLine();

            foreach(char c in input)
            {
                if(!alpha.Contains(c))
                {
                    sb.Append("NO");
                    break;
                }
            }

            if (sb.Length < 1) sb.Append("YES"); 

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
