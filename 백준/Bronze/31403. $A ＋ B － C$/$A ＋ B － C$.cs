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

            string A = sr.ReadLine();
            string B = sr.ReadLine();
            string C = sr.ReadLine();

            sb.Append(int.Parse(A) + int.Parse(B) - int.Parse(C));
            sb.AppendLine();
            sb.Append(int.Parse(A + B) - int.Parse(C));

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
