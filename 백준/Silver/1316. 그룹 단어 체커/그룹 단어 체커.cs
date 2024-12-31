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

            int n = int.Parse(sr.ReadLine());
            int result = 0;

            Dictionary<char, bool> dic = new Dictionary<char, bool>();

            for (int i = 0; i < n; i++)
            {
                dic.Clear();
                bool isClear = true;
                string input = sr.ReadLine();
                char past = input[0];

                foreach (char c in input)
                {
                    // 사전에 있다 -> 기존에 나왔음
                    if (dic.ContainsKey(c))
                    {
                        // 근데 이전 이랑 다르다? -> 연속하지 않는 문자
                        if (!past.Equals(c))
                        {
                            isClear = false;
                            break;
                        }
                    }
                    // 기존에 나온적 없음
                    else
                    {
                        dic.Add(c, true);
                    }
                    past = c;
                }

                if (isClear) result++;
            }
            sb.Append(result);

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
