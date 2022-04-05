using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_3
{
    //Задача 3. Двумерный массив размером 5х5 заполнен случайными нулями и единицами.
    //Игрок может ходить только по полям, заполненным единицами.
    //Проверьте, существует ли путь из точки [0, 0] в точку [4, 4]
    //(эти поля требуется принудительно задать равными единице).
    
    // считаю, что по диагонале ходить нельзя


    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];// { { 1, 0, 0, 0, 0 }, { 1, 1, 1, 1, 0 }, { 0, 1, 0, 1, 0 }, { 0, 0, 1, 1, 1 }, { 0,1,0,0,1} };
            
            // для квадратного поля
            int leni = array.GetLength(0);
            int lenj = array.GetLength(1);

            FillArray(array); //создание случайной матрицы. закоментить для конкретной матрицы
            PrintArray(array);

            int twowave = 0;
            int firstwave = 1;

            for (firstwave = 1; firstwave < leni; firstwave++) // первая часть матрицы
            {
                for (int i = 0; i < firstwave; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        if (array[j, i - j] == firstwave)
                            CheckPos(j, (i - j));
                    }
                }
            }
            
            for (twowave = 0; twowave < leni; twowave++) // вторая часть матрицы
            {
                for (int i = twowave; i < leni; i++)
                {
                    for (int j = leni-1; j > twowave-1; j--)
                    {
                        if (array[i, j] == firstwave) 
                            CheckPos(i, j);
                    }
                }
                firstwave++;
            }


            //проверяем дошли ли мы до конца            
            if ((array[leni - 2, lenj - 1] > 1) || (array[leni - 1, lenj - 2] > 1))
                Console.WriteLine("Путь есть");
            else
                Console.WriteLine("Пути нет");

            PrintArray(array);

            Console.ReadLine();

            void FillArray(int[,] arr)
            {

                Random rnd = new Random();

                for (int i = 0; i < leni; i++)
                    for (int j = 0; j < lenj; j++)
                        arr[i, j] = rnd.Next(0, 2);

                arr[0, 0] = 1;
                arr[leni - 1, lenj - 1] = 1;
            }

            void PrintArray(int[,] arr)
            {
                for (int i = 0; i < leni; i++)
                {
                    for (int j = 0; j < lenj; j++)
                        Console.Write($" {arr[i, j]} |");
                    Console.WriteLine();
                }
            }

            void CheckPos (int i, int j) //проверяю возможность шага вправо и вниз
            {
                if ((j < leni-1)&(i < leni - 1))
                {
                    if (array[i, j + 1] == 1) //вправо
                        array[i, j + 1] += array[i, j];

                    if (array[i + 1, j] == 1) //вниз
                        array[(i + 1), j] += array[i, j];
                }
            }
        }
    }
}
