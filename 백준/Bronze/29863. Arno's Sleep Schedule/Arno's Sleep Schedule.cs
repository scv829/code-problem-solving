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

            int sleep = int.Parse(sr.ReadLine());
            int awake = int.Parse(sr.ReadLine());
            
            sb.Append( ( (sleep > 3) ? 24 - sleep + awake : awake - sleep ) );

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
