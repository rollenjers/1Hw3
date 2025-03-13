using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 целых чисел
        int[] array = new int[10];
        Random random = new Random();

        // Заполняем массив случайными числами (например, от 1 до 100)
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }

        // Выводим массив на экран
        Console.WriteLine("Массив: " + string.Join(", ", array));

        // Подсчитываем количество чётных чисел
        int evenCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenCount++;
            }
        }

        // Выводим результат
        Console.WriteLine("Количество чётных чисел в массиве: " + evenCount);
    }
}