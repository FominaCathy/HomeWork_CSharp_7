using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_2
{
    //Задача 2. Двумерный массив размером 3х4 заполнен числами от 100 до 9999.
    //Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения.
    //Выведите оба массива.

    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] twoArray = new int[3, 4];
            int[] newArray = new int[12];
            int summ = 0;
            int multy = 1;
            int road = twoArray.GetLength(0);
            int colone = twoArray.GetLength(1);
            int count = 0; // для одномерного массива

            CreateArray(twoArray); //печатаем двумерный массив
            PrintArray(twoArray);


            for (int i = 0; i < road; i++)
                for (int j = 0; j < colone; j++)
                {
                    summ = 0;
                    multy = 1;
                    CheckValue (twoArray[i, j]);
                    if (summ > multy)
                    {
                        newArray[count] = twoArray[i, j];
                        count++;
                    }
                }

            Console.WriteLine($"кол-во чисел: {count}");
            for (int i = 0; i < count; i++) Console.Write($"{newArray[i]} | ");


            Console.ReadLine();

            void CreateArray(int[,] array)
            {
                Random rnd = new Random();

                for (int i = 0; i < road; i++)
                    for (int j = 0; j < colone; j++)
                        array[i, j] = rnd.Next(100, 10000);
            }

            void PrintArray(int[,] array)
            {

                for (int i = 0; i < road; i++)
                {
                    for (int j = 0; j < colone; j++)
                        Console.Write($"{array[i, j]} | ");
                    Console.WriteLine();
                }
            }

            void CheckValue (int number)
            {

                while (number > 0)
                {
                    summ = summ + number % 10;
                    multy =  multy * (number % 10);
                    number /= 10;
                }
    
            }


        }
    }
}
