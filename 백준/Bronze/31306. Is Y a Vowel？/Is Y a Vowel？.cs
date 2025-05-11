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

            string input = sr.ReadLine();

            int y_count = 0;
            int count = 0;

            foreach (char c in input) 
            { 
                if(c == 'y') y_count++;
                else if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') count++;
            }

            sb.Append($"{count} {count + y_count}");

            sw.WriteLine( sb.ToString() );

            sw.Close();
            sr.Close();
        }

    }
}
