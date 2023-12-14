// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Задача №1
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        void PrintNaturalNumbers(int start, int end)
        {
            if (start <= end)
            {
                Console.Write($"{start}, ");
                PrintNaturalNumbers(start + 1, end);
            }
        }

        Console.Write("Натуральные числа в промежутке от M до N: ");
        PrintNaturalNumbers(m, n);
    }
}

Задача №2
using System;

class Program
{
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }

    static void Main()
    {
        int m = 2;
        int n = 1;
        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {AckermannFunction(m, n)}");
    }
}

Задача №3
using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        void PrintArrayReversed(int[] arr, int index)
        {
            if (index >= 0)
            {
                Console.Write($"{arr[index]} ");
                PrintArrayReversed(arr, index - 1);
            }
        }

        Console.Write("Элементы массива, начиная с конца: ");
        PrintArrayReversed(array, array.Length - 1);
    }
}
