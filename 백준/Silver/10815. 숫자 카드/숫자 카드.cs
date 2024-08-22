using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int.TryParse(Console.ReadLine(), out int N);

            string[] line = Console.ReadLine().Split(' ');

            Dictionary<int, bool> dic = new Dictionary<int, bool>();

            foreach( string s in line)
            {
                dic[int.Parse(s)] = true;
            }

            int.TryParse(Console.ReadLine(), out int M);
            int[] findNum = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < findNum.Length; i++)
            {
                if (dic.ContainsKey(findNum[i]))
                {
                    sb.Append(1 + " ");
                }
                else
                {
                    sb.Append(0 + " ");
                }
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
