using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace code
{
    class Program
    {
        
        static void Main(string[] args)
        {
            LinkedList<char> lists = new LinkedList<char>();

            StringBuilder sb = new StringBuilder(Console.ReadLine());

            for(int i = 0; i < sb.Length; i++)
            {
                lists.AddLast(sb[i]);
            }
            lists.AddLast(' ');

            LinkedListNode<char> cursor = lists.Last;
            int.TryParse(Console.ReadLine(), out int N);

            for(int i = 0; i < N; i++)
            {
                sb.Clear();
                sb.Append(Console.ReadLine());

                switch (sb[0])
                {
                    case 'L':
                        if (cursor.Previous != null) cursor = cursor.Previous;
                        break;
                    case 'D':
                        if (cursor.Next != null) cursor = cursor.Next;
                        break;
                    case 'B':
                        if (cursor.Previous != null) lists.Remove(cursor.Previous);
                        break;
                    case 'P':
                        lists.AddBefore(cursor, sb[sb.Length - 1]);
                        break;
                }
            }
            lists.RemoveLast();

            sb.Clear();

            foreach (char c in lists)
            {
                sb.Append(c);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
