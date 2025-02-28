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
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                { 'A', 3 }, { 'B', 3 } ,{ 'C', 3 } ,
                { 'D', 4 }, { 'E', 4 } ,{ 'F', 4 } ,
                { 'G', 5 }, { 'H', 5 } ,{ 'I', 5 } ,
                { 'J', 6 }, { 'K', 6 } ,{ 'L', 6 } ,
                { 'M', 7 }, { 'N', 7 } ,{ 'O', 7 } ,
                { 'P', 8 }, { 'Q', 8 } ,{ 'R', 8 } , { 'S', 8 } ,
                { 'T', 9 }, { 'U', 9 } ,{ 'V', 9 } ,
                { 'W', 10 }, { 'X', 10 } ,{ 'Y', 10 } , { 'Z', 10 } ,
            };

            string input = sr.ReadLine();
            int result = 0;

            foreach (char c in input)
            {
                result += map[c];
            }
            sb.Append(result);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}