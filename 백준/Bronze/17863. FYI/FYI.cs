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

            sb.Append( (sr.ReadLine().Substring(0,3).Equals("555") ? "YES": "NO") );

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
