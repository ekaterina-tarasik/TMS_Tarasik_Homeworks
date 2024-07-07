using System.Text;

class Calculator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.GetEncoding("utf-8");
        Console.WriteLine("Введите первое значение:");
        int.TryParse(Console.ReadLine(), out var num1);
        Console.WriteLine("Введите второе значение:");
        int.TryParse(Console.ReadLine(), out var num2);
        Console.WriteLine("Введите желаемую операцию:" +
            "1. Сложение\n" +
            "2. Вычитание\n" +
            "3. Умножение\n" +
            "4. Деление\n" +
            "5. Процент от числа\n" +
            "6. Квадратный корень числа");
        var operation = Console.ReadLine();
        double result1 = 0;
        double result2 = 0;

        switch (operation)
        {
            case "1":
                result1 = num1 + num2;
                break;
            case "2":
                result1 = num1 - num2;
                break;
            case "3":
                result1 = num1 * num2;
                break;
            case "4":
                result1 = num1 / num2;
                break;
            case "5":
                result1 = (num1 / num2 * 100);
                break;
            case "6":
                result1 = Math.Round(Convert.ToDouble(Math.Sqrt(num1)), 2);
                result2 = Math.Round(Convert.ToDouble(Math.Sqrt(num2)), 2);
                break;
        }
        if (operation == "1" || operation == "2" || operation == "3" || operation == "4")
        {
            Console.WriteLine("Результат: " + (result1));
        }
        else if (operation == "5")
        {
            Console.WriteLine("Результат: " + (result1) + "%");
        }
        else if (operation == "6")
            Console.WriteLine($"Результат:\nКвадратный корень {num1} - " + (result1) + "\n" + $"Квадратный корень числа {num2} - " + (result2));
    }
}