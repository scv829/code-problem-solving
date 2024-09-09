using System;
using System.Collections.Generic;
namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            LinkedList<int> deque1 = new LinkedList<int>();
            LinkedList<int> deque2 = new LinkedList<int>();

            int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 1; i <= ints[0]; i++)
            {
                deque1.AddLast(i);
                deque2.AddLast(i);
            }

            int[] findNums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int index = 0;
            int count = 0;

            while (index < ints[1])
            {
                if (findNums[index] == deque1.First.Value)
                {
                    deque1.RemoveFirst();
                    deque2.RemoveFirst();
                    index++;
                }
                else
                {
                    int countLeft = 0;
                    int countRight = 0;

                    MoveLeft(ref deque1, findNums[index], ref countLeft);
                    MoveRight(ref deque2, findNums[index], ref countRight);

                    if (countLeft < countRight)
                    {
                        count += countLeft;
                        deque2.Clear();
                        foreach (int value in deque1) deque2.AddLast((int)value);
                    }
                    else
                    {
                        count += countRight;
                        deque1.Clear();
                        foreach (int value in deque2) deque1.AddLast((int)value);
                    }
                }
            }

            Console.WriteLine(count);

        }

        static void MoveLeft(ref LinkedList<int> deque, int num, ref int count)
        {

            deque.AddFirst(deque.Last.Value);
            deque.RemoveLast();
            count++;
            if (num != deque.First.Value) { MoveLeft(ref deque, num, ref count); }

            return;

        }

        static void MoveRight(ref LinkedList<int> deque, int num, ref int count)
        {

            deque.AddLast(deque.First.Value);
            deque.RemoveFirst();
            count++;
            if (num != deque.First.Value) { MoveRight(ref deque, num, ref count); }

            return;
        }

    }
}