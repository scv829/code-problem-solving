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

            string jae = sr.ReadLine();
            string dr = sr.ReadLine();

            int jae_count = jae.Count(x => x.Equals('a'));
            int dr_count = dr.Count(x => x.Equals('a'));

            sb.Append($"{((jae_count < dr_count) ? "no" : "go")}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}