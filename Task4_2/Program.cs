//Задайте массив заполненный случайными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100, 1000);
            Console.Write($"[{array[i]}] ");
        }
        int count = 0;
        foreach (int e in array)
        {
            if (e % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Число четных чисел массива: {count}.");


    }
}