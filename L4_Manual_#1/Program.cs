﻿using System.Net.NetworkInformation;
using System.Text;

//1. При помощи цикла for вывести на экран нечетные числа от 1 до 99. При решении используйте операцию инкремента (++).
class Cycle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.GetEncoding("utf-8");
        Console.WriteLine("1. При помощи цикла for вывести на экран нечетные числа от 1 до 99. При решении используйте операцию инкремента (++).");
        Console.WriteLine();       
        for (int i = 0; i < 100 ; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + ", ");                
            }                    
            
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("2. Необходимо вывести на экран числа от 5 до 1. При решении используйте операцию декремента (--).");
        Console.WriteLine();
        for (var a = 5; a > 0; a--)
        {
            if (a == 0)
            {
                continue;
            }
            Console.Write(a + ", ");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("3. Напишите программу, где пользователь вводит любое целое положительное число. А программа суммирует все числа от 1 до введенного пользователем числа. Для ввода числа воспользуйтесь Console.ReadLine.");
        Console.WriteLine();
        int number;
        Console.Write("Введите целое положительное число: ");
        var userInput = Console.ReadLine();
        int.TryParse(userInput, out number);
        int sum = 0;
        for (int k = 1; k <= number; k++)
        {
            sum +=  k;
        }
        Console.WriteLine($"Сумма чисел от 1 до {number}: " + sum);
        Console.WriteLine();

        Console.WriteLine("4. Необходимо, чтоб программа выводила на экран вот такую последовательность: 7 14 21 28 35 42 49 56 63 70 77 84 91 98");
        Console.WriteLine();
        int c = 7;
        int d = 1;
        while (d < 15)
        {
            Console.Write(c*d + " ");
            d++;
        }
        Console.WriteLine();
        Console.WriteLine();
        int h = 0;
        Console.WriteLine("5. Вывести 10 первых чисел последовательности 0, -5,-10,-15...");
        Console.WriteLine();        
        for (int f = 0; f < 10; f++)
        {
            Console.Write(h + ", ");
            h = h - 5;            
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("6. Составьте программу, выводящую на экран квадраты чисел от 10 до 20 включительно");
        Console.WriteLine();
        for (int s = 10; s <= 20; s ++)
        {
            Console.WriteLine($"Квадрта {s}: "+ (s * s) + " ");           
        }   
        Console.WriteLine();
    }
}
