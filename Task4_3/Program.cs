//Напишите программу, которая перевернёт одномерный массив
//(первый элемент станет последним, второй – предпоследним и т.д.)

using System;
class Program
{
    static void Main()
    {
        int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        int size = array.Length;
        int k = array.Length / 2;
        int temp = 0;
        for ( int i = 0; i < k; i++)
        {
            temp = array [size - i - 1];
            array [size - i - 1] = array[i];
            array[i] = temp;
        }
        foreach (int e in array)
        {
            Console.Write($"[{e}] ");
        }
    }
}