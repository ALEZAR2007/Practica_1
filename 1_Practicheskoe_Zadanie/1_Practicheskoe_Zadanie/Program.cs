using System;

public class Program_1
{
    public static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int w = a + b;
        Console.WriteLine($"Сумма чисел {a} и {b} равна: {w}");

        Console.Write("Введите первое число: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int d = Convert.ToInt32(Console.ReadLine());
        int q = c - d;
        Console.WriteLine($"Разность чисел {c} и {d} равна: {q}");
    }
}


