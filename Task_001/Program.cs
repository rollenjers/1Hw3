using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 целых чисел
        int[] array = new int[10];
        Random random = new Random();

        // Заполняем массив случайными числами от 1 до 100
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }

        // Выводим массив на экран
        Console.WriteLine("Массив: " + string.Join(", ", array));

        // Подсчитываем количество элементов в отрезке [20, 90]
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 20 && array[i] <= 90)
            {
                count++;
            }
        }

        // Выводим результат
        Console.WriteLine("Количество элементов в отрезке [20, 90]: " + count);
    }
}
