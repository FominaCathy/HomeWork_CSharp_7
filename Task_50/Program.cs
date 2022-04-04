using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_50
{
    //Задача 50:
    //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    //и возвращает значение этого элемента или же указание, что такого элемента нет.
    internal class Program
    {
        static void Main(string[] args)
        {

            double[,] NewArray = new double[5, 10];
            int numroad = 3;
            int numcolone = 9;

            CreateArray(NewArray);
            PrintArray(NewArray);

            if ((numroad < NewArray.GetLength(0)) & (numcolone < NewArray.GetLength(1)))
                Console.WriteLine($"значение в позиции {numroad}, {numcolone} = {NewArray[numroad, numcolone]:f02}");
            else
                Console.WriteLine($"такого элемента нет");


            Console.ReadLine();

            void CreateArray(double[,] array)
            {
                Random rnd = new Random();
                int road = array.GetLength(0);
                int colone = array.GetLength(1);
                for (int i = 0; i < road; i++)
                    for (int j = 0; j < colone; j++)
                        array[i, j] = rnd.NextDouble() + rnd.Next(-10, 10);
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
