using System;
using System.Collections.Generic;
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

            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                { "SONGDO", "HIGHSCHOOL" },
                { "CODE", "MASTER" },
                { "2023", "0611" },
                { "ALGORITHM", "CONTEST" },
            };

            string input = sr.ReadLine();

            sb.Append(dic[input]);

            sw.WriteLine( sb.ToString() );

            sw.Close();
            sr.Close();
        }

    }
}
