using System;

namespace ShapeFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int row;
            int column;

            Console.WriteLine("Draw Figures");
            Console.Write("Enter a number to draw a square: ");
            input = Console.ReadLine();
            row = int.Parse(input);

            PrintBox(row, row);

            Console.Write("Enter Two number to draw a rectangle: ");
            input = Console.ReadLine();
            row = int.Parse(input.Split()[0]);
            column = int.Parse(input.Split()[1]);
            PrintBox(row, column);

            Console.ReadKey();

        }

        static void PrintBox(int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == 0 || i == row - 1)
                    {
                        Console.Write("* ");
                    }
                    else if (j == 0 || j == column - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}