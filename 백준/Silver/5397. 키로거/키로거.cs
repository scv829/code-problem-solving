using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            LinkedList<char> list = new LinkedList<char>();

            StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());

            string[] result = new string[N];

            for (int i = 0; i < N; i++)
            {
                list.Clear();
                sb.Clear();
                sb.Append(Console.ReadLine());
                list.AddLast(' ');
                LinkedListNode<char> cursor = list.Last;

                for (int j = 0; j < sb.Length; j++)
                {
                    switch (sb[j])
                    {
                        case '<':
                            if (cursor.Previous != null) cursor = cursor.Previous;
                            break;
                        case '>':
                            if (cursor.Next != null) cursor = cursor.Next;
                            break;
                        case '-':
                            if (cursor.Previous != null) list.Remove(cursor.Previous);
                            break;
                        default:
                            list.AddBefore(cursor, sb[j]);
                            break;
                    }
                }

                list.RemoveLast();
                sb.Clear();
                foreach (char c in list) { sb.Append(c); }
                result[i] = sb.ToString();
            }

            foreach (string line in result)
            {
                Console.WriteLine(line);
            }

        }
    }
}
