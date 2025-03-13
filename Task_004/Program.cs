using System;

class Program
{
    static void Main()
    {
        // Вводим натуральное число
        Console.Write("Введите натуральное число от 1 до 100 000: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверяем, что число находится в допустимом диапазоне
        if (number < 1 || number > 100000)
        {
            Console.WriteLine("Число должно быть в диапазоне от 1 до 100 000.");
            return;
        }

        // Определяем количество цифр в числе
        int length = number.ToString().Length;

        // Создаем массив для хранения цифр числа
        int[] digits = new int[length];

        // Заполняем массив цифрами числа
        for (int i = 0; i < length; i++)
        {
            digits[i] = number / (int)Math.Pow(10, length - 1 - i) % 10;
        }

        // Выводим массив на экран
        Console.WriteLine("Массив цифр числа: " + string.Join(", ", digits));
    }
}