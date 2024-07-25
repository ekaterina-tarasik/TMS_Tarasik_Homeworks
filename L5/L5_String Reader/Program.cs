using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

class Program
//    Считать строку текста из консоли (продвинутое задание: из файла).
//Строка содержит буквы латинского алфавита, знаки препинания и цифры.
//Реализовать меню выбора действий:
//- Найти слова, содержащие максимальное количество цифр.
//- Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.
//- Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».
//- Вывести на экран сначала вопросительные, а затем восклицательные предложения.
//- Вывести на экран только предложения, не содержащие запятых.
//- Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.
//Приложение не должно падать ни при каких условиях

{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.GetEncoding("utf-8");
        Console.WriteLine("Выберите метод ввода текста:" + "\n1 - С консоли" + "\n2 - Из документа");
        Console.WriteLine();

        while (true)
        {
            var userChoice1 = Console.ReadLine();
            Console.WriteLine();
            string Text = String.Empty;
            bool cancellation = false;
            switch (userChoice1)
            {
                case "1": // 1. Считать строку текста из консоли
                {
                    Console.WriteLine("Введите текст:\n");
                    Text = Console.ReadLine();
                    Console.WriteLine();
                    break;
                }
                case "2"://считать строку из файла
                {
                    Console.WriteLine("Введите путь к документу:\n");
                    var DocLink = Console.ReadLine();
                    Text = File.ReadAllText(DocLink); //txt file
                    Console.WriteLine(Text);
                    break;
                }
            }

            // 3. Реализовать меню выбора действий
            Console.WriteLine("Выберите действиеЖ:\n" +
                    "\n1 - Найти слова, содержащие максимальное количество цифр." +
                    "\n2 - Найти самое длинное слово и определить, сколько раз оно встретилось в тексте." +
                    "\n3 - Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять»." +
                    "\n4 - Вывести на экран сначала вопросительные, а затем восклицательные предложения." +
                    "\n5 - Вывести на экран только предложения, не содержащие запятых." +
                    "\n6 - Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву." +
                    "\n0 - Выйти из программы");

            Console.WriteLine();
            while (true)
            {
                var userChoice2 = Console.ReadLine();
                Console.WriteLine();
                switch (userChoice2)
                {
                    case "1": // Найти слова, содержащие максимальное количество цифр
                    {
                        string[] SeperatedStrings = Text.Split(new char[] { ' ', '.', ',', ';', ':', '\n', '\r', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                        var CountOfNumbers = 0; // количество цифр в слове
                        var StringResult = string.Empty; // пустая строка
                        var maxCount = 0;

                        foreach (var Word in SeperatedStrings)
                        {

                            for (int i = 0; i < Word.Length; i++)
                            {
                                if (Char.IsDigit(Word[i])) // Проверяет Word[i] является ли числом? Если является, то выполняем действие
                                {
                                    CountOfNumbers++;
                                }
                            }
                            if (CountOfNumbers > maxCount)
                            {
                                StringResult = Word;
                                maxCount = CountOfNumbers;
                            }
                            CountOfNumbers = 0;
                        }
                        Console.WriteLine($"Cлова, содержащие максимальное количество цифр: {StringResult}." + "\nДля продолжения выберите действие от 1 до 6 или нажмите 0 для выхода");
                        Console.WriteLine();
                        break;
                    }
                    case "2": // Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.
                    {
                        string[] SeperatedStrings = Text.Split(new char[] { ' ', '.', ',', ';', ':', '\n', '\r', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                        var StringResult = string.Empty; // пустая строка
                        var maxLength = 0;
                        int counterRepeat = 1;
                        int index = 0;

                        for (int i = 0; i < SeperatedStrings.Length; i++)
                        {
                            if (SeperatedStrings[i].Length > maxLength) //находим самое длинное слово
                            {
                                maxLength = SeperatedStrings[i].Length;
                                index = i;
                                StringResult = SeperatedStrings[i];
                                continue;
                            }
                            if (SeperatedStrings[i] == StringResult) // считаем количество раз, сколько это слово встретилось в тексте
                            {
                                counterRepeat++;
                            }
                        }

                        Console.WriteLine($"Cамое длинное слово: {SeperatedStrings[index]}\n" + $"\nСколько раз встретилось в тексте? - {counterRepeat} раз" + "\nДля продолжения выберите действие от 1 до 6 или нажмите 0 для выхода");
                        Console.WriteLine();
                        break;
                    }
                    case "3": // Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».
                    {
                        StringBuilder sb = new StringBuilder(Text);
                        sb.Replace("0", "ноль");
                        sb.Replace("1", "один");
                        sb.Replace("2", "два");
                        sb.Replace("3", "три");
                        sb.Replace("4", "четыре");
                        sb.Replace("5", "пять");
                        sb.Replace("6", "шесть");
                        sb.Replace("7", "семь");
                        sb.Replace("8", "восемь");
                        sb.Replace("9", "девять");
                        Console.WriteLine($"{sb}");
                        Console.WriteLine("\nДля продолжения выберите действие от 1 до 6 или нажмите 0 для выхода");
                        Console.WriteLine();
                        break;
                    }
                    case "4": //Вывести на экран сначала вопросительные, а затем восклицательные предложения.
                    {
                        Text = Regex.Replace(Text, @"[\r\n\t]", "");
                        string[] SeperatedStrings = Regex.Split(Text, @"(?<=[\.\!\?])");
                        var StringResult = string.Empty;

                        Console.Write("Вопросительные предложения:\n");
                        for (int i = 0; i < SeperatedStrings.Length; i++)
                        {
                            if (SeperatedStrings[i].Contains('?'))
                            {
                                StringResult = SeperatedStrings[i];

                                Console.WriteLine("- " + StringResult + "\n");
                            }

                        }
                        Console.WriteLine();
                        Console.WriteLine("Восклицательные предложения:\n");
                        for (int i = 0; i < SeperatedStrings.Length; i++)
                        {
                            if (SeperatedStrings[i].Contains('!'))
                            {
                                StringResult = SeperatedStrings[i];
                                Console.WriteLine("- " + StringResult + "\n");
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Для продолжения выберите действие от 1 до 6 или нажмите 0 для выхода");
                        Console.WriteLine();
                        break;
                    }
                    case "5": //Вывести на экран только предложения, не содержащие запятых.
                    {
                            Console.WriteLine("Предложения, не содержащие запятых:");
                        Text = Regex.Replace(Text, @"[\r\n\t]", "");
                        string[] SeperatedStrings = Regex.Split(Text, @"(?<=[\.\!\?])");
                        var StringResult = string.Empty;
                        for (int i = 0; i < SeperatedStrings.Length; i++)
                        {
                            if (!SeperatedStrings[i].Contains(','))
                            {
                                Console.WriteLine("- " + SeperatedStrings[i] + "\n");
                            }

                        }
                        Console.WriteLine("\nДля продолжения выберите действие от 1 до 6 или нажмите 0 для выхода");
                        Console.WriteLine();
                        break;
                    }
                    case "6": //Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.
                    {
                        Console.WriteLine("Слова, начинающиеся и заканчивающиеся на одну и ту же букву:");
                        Text = Regex.Replace(Text, @"[\r\n\t]", "");
                        //string[] SeperatedStrings = Regex.Split(Text, @"(?<=[\:\;\ \,\.\!\?])");
                        string[] SeperatedWords = Text.Split(new char[] { ' ', '.', ',', ';', ':', '\n', '\r', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string Word in SeperatedWords)
                        {
                            if (Word.Length > 1 && Word[0] == Word[Word.Length - 1])
                            {
                                Console.WriteLine(Word);
                            }
                        }
                       
                        Console.WriteLine("\nДля продолжения выберите действие от 1 до 6 или нажмите 0 для выхода\n");
                        Console.WriteLine();
                        break;
                    }
                    case "0": // Выход из программы
                    {
                        cancellation = true;
                        return;
                    }
             
                }
            }
        }
    }
    } 