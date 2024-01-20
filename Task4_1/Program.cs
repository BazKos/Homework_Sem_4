//Напишите программу, которая бесконечно запрашивает целые числа
//с консоли. Программа завершается при вводе символа ‘q’ или при
//вводе числа, сумма цифр которого чётная.


using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число N:");
            string input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"Программа завершена. Сумма цифр числа {input} - четное число.");
                    break;
                }   
            }
            else
            {
                Console.WriteLine("Ошибка! Введите целое число или нажмите Q для завершения цикла.");
            }
        }
    }
}