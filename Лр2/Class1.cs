using System;
using System.Reflection.Metadata;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 1
        // Напишіть програму, яка знаходить: суму всіх елементів у заданому масиві.
        //+Напишіть програму, яка знаходить мінімальний і максимальний елементи у масиві.
        //+Напишіть програму, яка знаходить середнє значення елементів у масиві.
        //+Напишіть програму, яка перевіряє, чи міститься певний елемент у масиві.
        Console.WriteLine("1.");
        Random random = new Random();
        int[] tab = new int[10];


        for (int i = 0; i < 10; i++)
        {
            for (int b = 0; b < 1; b++)
            {
                tab[i] = random.Next(0, 99);
            }
            Console.Write(tab[i] + " ");
        }
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += tab[i];
        }
        Console.WriteLine("Сума: " + sum);
        int max = tab.Max();
        Console.WriteLine("Максимальне значення: " + max);
        int min = tab.Min();
        Console.WriteLine("Мінімальне значення: " + min);
        double average = tab.Average();
        Console.WriteLine("Середнє значення: " + average);
        int Find = int.Parse(Console.ReadLine());

        if (tab.Contains(Find))
        {
            Console.WriteLine("Елемент " + Find + " знайдено в масиві.");
        }
        else
        {
            Console.WriteLine("Елемент " + Find + " не знайдено в масиві.");
        }
        Console.WriteLine("2.");
        int[,] mas = new int[3, 3];
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                mas[i, j] = random.Next(1, 100);
            }
        }
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                Console.Write(mas[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }
}
