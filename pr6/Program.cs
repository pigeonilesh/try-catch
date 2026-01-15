using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[5];
            int i = 0;
            Console.WriteLine($"Заполните массив 5 числами:");
            while ( i < mas.Length)
            {
                try
                {
                    Console.WriteLine($"Введите число {i + 1}:");
                    mas[i] = int.Parse(Console.ReadLine());
                    i++;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Ошибка: возможен ввод только чисел.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"Ошибка: значение вышли за границы массива.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
                }
            }
            Console.WriteLine($"Ввод завершен, Заполненый массив:");
            for (int j = 0; j < mas.Length; j++)
            {
                Console.WriteLine($"mas[{j}] = {mas[j]}");
            }
        }
    }
}
