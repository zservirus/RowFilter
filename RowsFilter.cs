// Программа фильрование строк
//using FilterStart;

namespace RowsFilter
{
    public static class RowsFilter
    {
        public static void Main()
        {
            int size = 10;
            int min = 0;
            int max = 10000;
            string[] myrows = CreateArray(size, min, max);
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

