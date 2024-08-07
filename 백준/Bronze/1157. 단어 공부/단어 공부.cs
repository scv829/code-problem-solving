using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            string line = Console.ReadLine().ToUpper();
            StringBuilder sb = new StringBuilder();
            int[] alphabet = new int[26];

            foreach (char c in line)
            {
                alphabet[c -'A']++;
            }

            bool flag = false;
            int max = alphabet.Max();

            for(int i = 0; i < 26; i++)
            {
                if (alphabet[i] == max) 
                { 
                    if(flag) { sb.Clear(); sb.Append('?'); break; }
                    sb.Append((char)('A' + i)); flag = true; 
                }
               
            }
            
            Console.WriteLine(sb.ToString());

        }
    }
}