using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);

            BigInteger num = 1;
            int result = 0;

            for(int i = 1; i <= N; i++)
            {
                num *= (BigInteger)i;
            }

            string s = num.ToString();

            IEnumerable<char> chars = s.Reverse();

            foreach(char c in chars)
            {
                if (c == '0') result++;
                else break;
            }

            Console.WriteLine(result);

        }
    }
}