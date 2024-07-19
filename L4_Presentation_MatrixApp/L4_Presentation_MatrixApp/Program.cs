///Создать программу работы с матрицами (двухмерными массивами) c возможностью выбора размера
//матрицы
//Элементы вводятся вручную
//Вывести матрицу на консоль (добавить оформление, чтобы выглядело как матрица)
//Реализовать меню выбора действий:
//-Найти количество положительных/отрицательных чисел в матрице
//- Сортировка элементов матрицы построчно (в двух направлениях)
//- Инверсия элементов матрицы построчно
//- Все математические операции реализовать вручную, без использования статических методов класса
//Array
//Рекомендация:
//Поскольку надо изменять элементы массива, то для этого используется цикл for


using System.Text;

class MatrixApp
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.GetEncoding("utf-8");
        int rowNumber, colNumber;
        while (true)
        {
            Console.WriteLine("Введите количество строк массива");
            var userInput1 = Console.ReadLine();
            int.TryParse(userInput1, out rowNumber);


            Console.WriteLine("Введите количество столбцов массива");
            var userInput2 = Console.ReadLine();
            int.TryParse(userInput2, out colNumber);

            if (rowNumber != default && colNumber != default)
            {
                break;
            }
            else
            {
                Console.Clear();
            }
        }

        int[,] array = new int[rowNumber, colNumber];
        for (int i = 0; i < rowNumber; i++)
        {
            for (int j = 0; j < colNumber; j++)
            {
                Console.Write($"Введите элемент массива: ");
                var element = Console.ReadLine();
                array[i, j] = int.Parse(element);
            }
        }
        Console.Clear();
        for (int i = 0; i < rowNumber; i++)
        {
            for (int j = 0; j < colNumber; j++)
            {
                Console.Write($" {array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Выберите желаемое действиеЖ:\n" +
            "1 - Найти количество положительных чисел в матрице\n" +
            "2 - Найти количество отрицательных чисел в матрице\n" +
            "3 - Сортировка элементов матрицы построчно по возрастанию\n" +
            "4 - Сортировка элементов матрицы построчно по убыванию\n" +
            "5 - Инверсия элементов матрицы построчно\n"+
            "0 - Выйти из программы");
        Console.WriteLine();
        while (true)
        {
            bool cancellation = false;
            var userChoice = Console.ReadLine();
            Console.WriteLine();
            switch (userChoice)
            {
                case "1":
                    {
                        int positiveCount = 0;
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                if (array[i, j] > 0)
                                {
                                    positiveCount++;
                                }
                            }
                        }
                        Console.WriteLine($"Количество положительных элементов в массиве: {positiveCount}." + "\nДля продолжения выберите действие от 1 до 5 или нажмите 0 для выхода");                                                                
                        Console.WriteLine();
                        break;
                    }
                case "2":
                    {
                        int negativeCount = 0;
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                if (array[i, j] < 0)
                                {
                                    negativeCount++;
                                }
                            }
                        }
                        Console.WriteLine($"Количество отрицательных элементов в массиве: {negativeCount}" + "\nДля продолжения выберите действие от 1 до 5 или нажмите 0 для выхода" );
                        Console.WriteLine();
                        break;
                    }
                case "3": //Сортировка пузырьком по возрастанию
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            for (int k = 0; k < array.GetLength(1) - 1; k++)
                            {
                                if (array[i, k] > array[i, k + 1])
                                {
                                    int temp = array[i, k];
                                    array[i, k] = array[i, k + 1];
                                    array[i, k + 1] = temp;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"Сортировка элементов матрицы построчно по возрастанию:");
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nДля продолжения выберите действие от 1 до 5 или нажмите 0 для выхода");
                    Console.WriteLine();
                    break;
                    }
                case "4": //Сортировка пузырьком по убыванию
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            for (int k = 0; k < array.GetLength(1) - 1; k++)
                            {
                                if (array[i, k] < array[i, k + 1])
                                {
                                    int temp = array[i, k];
                                    array[i, k] = array[i, k + 1];
                                    array[i, k + 1] = temp;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"Сортировка элементов матрицы построчно по убыванию:");
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nДля продолжения выберите действие от 1 до 5 или нажмите 0 для выхода");
                    Console.WriteLine();
                    break;
                }
                case "5": // Инверсия --> 12345 превратится в 54321
                {
                    Console.WriteLine();
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        int str = array.GetLength(1) / 2;
                        for (int j = 0; j < str; j++)
                        {
                            int temp2 = array[i, j];
                            array[i, j] = array[i, array.GetLength(1) - 1 - j];
                            array[i, array.GetLength(1) - 1 - j] = temp2;
                        }
                    }
                    Console.WriteLine($"Инверсия элементов матрицы построчно:");
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nДля продолжения выберите действие от 1 до 5 или нажмите 0 для выхода");
                    Console.WriteLine();
                    break;
                }
                case "0": // Выход из программы
                {
                    cancellation = true;
                    break;
                }
            }
            if (cancellation)
            {
                break;
            }
        }
    }
}
