using System.Net.NetworkInformation;
using System.Text;

//1. При помощи цикла for вывести на экран нечетные числа от 1 до 99. При решении используйте операцию инкремента (++).
class Cycle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.GetEncoding("utf-8");
        Console.WriteLine("1. При помощи цикла for вывести на экран нечетные числа от 1 до 99. При решении используйте операцию инкремента (++).");
        Console.WriteLine();
        var i = 0;
        for (i = 0; i < 100; i++)
        {
            if (i == 100)
            {
                continue;
            }
            Console.Write(i + ", ");           
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("2. Необходимо вывести на экран числа от 5 до 1. При решении используйте операцию декремента (--).");
        Console.WriteLine();
        var a = 5;
        for (; a > 0; a--)
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

        Console.WriteLine("5. Вывести 10 первых чисел последовательности 0, -5,-10,-15...");
        Console.WriteLine();
        int f = 0;
        int h = 0;
        for (; f < 10;)
        {
            Console.Write(h + ", ");
            h = h - 5;
            f++;
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("6. Составьте программу, выводящую на экран квадраты чисел от 10 до 20 включительно");
        Console.WriteLine();
        int s = 10;
        for (; s <= 20;)
        {
            Console.WriteLine($"Квадрта {s}: "+ (s * s) + " ");
            s++;
        }   
        Console.WriteLine();
    }
}
