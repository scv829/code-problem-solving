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

            Dictionary<string, int> resistance = new Dictionary<string, int>()
            {
                {"black", 0 },
                {"brown",1 },
                {"red",2 },
                {"orange", 3 },
                {"yellow", 4 },
                {"green", 5 },
                {"blue", 6 },
                {"violet", 7 },
                {"grey",8},
                {"white",9 }
            };

            Dictionary<string, long> value = new Dictionary<string, long>()
            {
                {"black", 1 },
                {"brown",10 },
                {"red",100 },
                {"orange", 1000 },
                {"yellow", 10000 },
                {"green", 100000 },
                {"blue", 1000000 },
                {"violet", 10000000 },
                {"grey",100000000},
                {"white",1000000000 }
            };
            sb.Append($"{(resistance[sr.ReadLine()] *10 + resistance[sr.ReadLine()]) * value[sr.ReadLine()]}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}