using System;
namespace W121___2D_Arrays
{
    internal class Program
    {
        static void assign(string[,] array)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = " | ";
                }
            }
        }
        static void display(string[,] array)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[i, j]);
                }
            }
        }
        static void random(string[,] array)
        {
            Random rnd = new Random();
            int row = rnd.Next(0, 4);
            int column = rnd.Next(0, 4);
            array[row, column] = " X ";
            Console.WriteLine("X is at " + row + ", " + column);
            guess(array, row, column);
        }
        static void guess(string[,] array, int row, int column)
        {
            bool found = false;
            while (!found)
            {
                Console.WriteLine("Guess the row of X");
                int rowGuess = int.Parse(Console.ReadLine());
                Console.WriteLine("Guess the column of X");
                int columnGuess = int.Parse(Console.ReadLine());
                if (rowGuess == row && columnGuess == column)
                {
                    Console.WriteLine("You found X!");
                    found = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You didn't find X, try again!\n");
                }
            }
            display(array);
        }
        static void Main(string[] args)
        {
            string[,] array = new string[4, 4];
            assign(array);
            random(array);
            Console.ReadKey();
        }
    }
}
