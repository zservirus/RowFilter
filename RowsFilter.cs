// Программа фильрование строк
//using FilterStart;

using System;
using System.Runtime.ExceptionServices;

namespace RowsFilter
{
    public static class RowsFilter
    {
        public static void Main()
        {
            int size = 10;
            int min = 0;
            int max = 10000;
            Console.Write("Ведите кол-во элементов в массиве строк или просто нажмите Enter(применится размер по умолчанию = 10 ):");
            string in_size = Console.ReadLine();
            if (in_size.Length > 0) { size = Convert.ToInt32(in_size); }

            string[] myrows = new string[size];
            Console.WriteLine($"Ведите масив строк из {size} елементов, или оставте пустым для генерации случайными значениями");
            Console.WriteLine("Введите 1-й элемент");
            string first = Console.ReadLine();
            if (first != "")
            {
                myrows[0] = first;
                for (int i = 1; i < size; i++)
                {
                    Console.WriteLine("Введите {0}-й элемент", i + 1);
                    myrows[i] = Console.ReadLine();
                }
            }
            else
            {
              myrows = CreateArray(size, min, max); 
            }
            Console.WriteLine("Из cгенерированного массива строк, формирует новый массив из строк, длина которых меньше, либо равна 3 символам.");
            PrintArray(myrows);
            Console.Write(" -> ");
            PrintArray(FilterStart.Filter(myrows));
            Console.ReadKey();
        }
        //Метод генерирует новый масив с заданными параметрами
        public static string[] CreateArray(int size, int min = 0, int max = 100000)
        {
            string[] newArray = new string[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                newArray[i] = rnd.Next(min, max).ToString();
            }
            return newArray;
        }
        
        // Метод вывода массива на экран в консоль
        public static void PrintArray(string[] array)
        {
        Console.Write($"[{ string.Join(",", array)}]");
        }
    }
}

