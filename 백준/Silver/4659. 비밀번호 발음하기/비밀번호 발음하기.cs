using System;
using System.Text;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string line = Console.ReadLine();
                bool isAcceptable = true;

                if (line == "end") break;
                else
                {
                    // 1.
                    if (!(line.Contains("a") || line.Contains("e") || line.Contains("i") || line.Contains("o") || line.Contains("u")))
                    {
                        isAcceptable = false;
                    }
                    else
                    {
                        for (int i = 0; i < line.Length - 1; i++)
                        {
                            // 3.
                            if (line[i] == line[i + 1] && (line[i] != 'e' && line[i] != 'o'))
                            {
                                isAcceptable = false;
                                break;
                            }
                            // 2. 모음이 3개 혹은 자음이 3개 연속으로 오면 안 된다.
                            if ((i < line.Length - 2) && (IsGather(line[i]) == IsGather(line[i + 1]) && IsGather(line[i]) == IsGather(line[i + 2])))
                            {
                                isAcceptable = false;
                                break;
                            }
                        }
                    }
                    sb.AppendLine((isAcceptable) ? $"<{line}> is acceptable." : $"<{line}> is not acceptable.");
                }

            }

            Console.WriteLine(sb.ToString());
        }

        public static bool IsGather(char c)
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }

    }
}
