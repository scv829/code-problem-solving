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

            foreach(char c in sr.ReadLine().Reverse())
            {
                sb.Append(c);
            }
            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}