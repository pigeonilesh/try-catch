using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5};
            try
            {
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
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
            Console.WriteLine($"Весь Массив: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
        }
    }
}
