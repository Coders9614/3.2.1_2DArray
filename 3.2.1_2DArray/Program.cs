using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._1_2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Assigment 3.2.1 2D array=======");
            Console.WriteLine("Enter the number of rows :");
            int rows = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of colums:");
            var cols = int.Parse(Console.ReadLine());

            int[,] readings = new int[rows, cols];

            Console.WriteLine($"Enter {rows * cols} readings");

            for (int i = 0; i < rows; i++) // rows
            {
                for (int j = 0; j < cols; j++)//cols
                {
                    Console.Write($"readings[{i},{j}]");
                    readings[i, j] = int.Parse(Console.ReadLine());// fill the array
                }
            }
            Console.WriteLine("You entered : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"| {readings[i, j]}  | \t"); // in 1 row
                }
                Console.WriteLine();// to go to next line to print next row
            }
            Console.ReadKey();
        }
    }
}
