using System;

namespace csharpVstavka
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите размерность массива");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[size];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 1; i < array.Length; i++)
                {
                    int j = i - 1;
                    int temp = array[i];
                    while (j >= 0 && array[j] > temp)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                    array[j + 1] = temp;
                }
                Console.WriteLine("Отсортированный массив: ");
                foreach (int element in array)
                {
                    Console.Write($"{element} ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
