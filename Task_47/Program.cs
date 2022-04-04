using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
namespace Task_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] NewArray = new double[5,10];

            CreateArray(NewArray);
            PrintArray(NewArray);

            Console.ReadLine();

            void CreateArray(double[,] array)
            {
                Random rnd = new Random();
                int road = array.GetLength(0);
                int colone = array.GetLength(1);
                for (int i = 0; i < road; i++)
                    for (int j = 0; j < colone; j++)
                        array[i,j] = rnd.NextDouble() + rnd.Next(-10,10);
            }

            void PrintArray(double[,] array)
            {
                int road = array.GetLength(0);
                int colone = array.GetLength(1);
                for (int i = 0; i < road; i++)
                {
                    for (int j = 0; j < colone; j++)
                        Console.Write($"{array[i, j]:f02} | ");
                    Console.WriteLine();
                }
            }

        }
    }
}
