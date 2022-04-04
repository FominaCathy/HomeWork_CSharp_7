using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_52
{
    internal class Program
    {
        //Задача 52:
        //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        static void Main(string[] args)
        {

            int [,] newArray = new int[5, 10];
            int numroad = newArray.GetLength(0);
            int numcolone = newArray.GetLength(1);
            double summcolone = 0;

            CreateArray(newArray);
            PrintArray(newArray);


            for (int j = 0; j < numcolone; j++)
            {
                summcolone = 0;
                for (int i = 0; i < numroad; i++)
                    summcolone += newArray[i, j];
                Console.WriteLine($"ср.арифм колонки {j} = {summcolone/numroad:f02}");
            }


            Console.ReadLine();

            void CreateArray(int[,] array)
            {
                Random rnd = new Random();
                int road = array.GetLength(0);
                int colone = array.GetLength(1);
                for (int i = 0; i < road; i++)
                    for (int j = 0; j < colone; j++)
                        array[i, j] = rnd.Next(0, 10);
            }

            void PrintArray(int[,] array)
            {
                int road = array.GetLength(0);
                int colone = array.GetLength(1);
                for (int i = 0; i < road; i++)
                {
                    for (int j = 0; j < colone; j++)
                        Console.Write($"{array[i, j]} | ");
                    Console.WriteLine();
                }
            }

        }
    }
}
