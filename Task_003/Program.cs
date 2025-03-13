using System;

class Program
{
    static void Main()
    {
        // Создаем массив из вещественных чисел с ненулевой дробной частью
        double[] array = new double[10];
        Random random = new Random();

        // Заполняем массив случайными вещественными числами
        for (int i = 0; i < array.Length; i++)
        {
            // Генерация случайного числа от 1.0 до 100.0 с ненулевой дробной частью
            array[i] = Math.Round(random.NextDouble() * 99 + 1, 1); // Округляем до 1 знаков после запятой
        }

        // Выводим массив на экран
        Console.WriteLine("Массив: " + string.Join(", ", array));

        // Находим минимальный и максимальный элементы массива
        double min = array[0];
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        // Вычисляем разницу между максимальным и минимальным элементами
        double difference = max - min;

        // Выводим результат
        Console.WriteLine("Минимальный элемент: " + min);
        Console.WriteLine("Максимальный элемент: " + max);
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }
}