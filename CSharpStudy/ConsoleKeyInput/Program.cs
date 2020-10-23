using System;
using System.Collections.Generic;

namespace ConsoleKeyInput
{
    class Program
    {
        static public int Calculate(int a, int b)
        {
            int abs_Sum = System.Math.Abs(a) + Math.Abs(b);
            return abs_Sum;
        }

        static void Main(string[] args)
        {
            List<char> keyList = new List<char>();
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();
                keyList.Add(key.KeyChar);
            } while (key.Key != ConsoleKey.Q); // Q가 아니면 계속

            Console.WriteLine();
            foreach (char ch in keyList) // 리스트 루프
            {
                Console.Write(ch);
            }

            int c = Calculate(10, 20);
        }

    }
}