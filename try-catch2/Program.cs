using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {10, 20, 30, 40, 50};
            try
            {
                Console.WriteLine($"Массив содержит 5 элементов (индексы 0-4)");
                Console.WriteLine($"Введите индекс элемента для отображения: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"Элемент с индексом {index}: {numbers[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Ошибка: указан неверный индекс.");
                Console.WriteLine($"Индекс должен быть от 0 до 4.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Ошибка: нужно вводить только числа.");
            }
            Console.WriteLine($"Весь Массив: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
        }
    }
}
