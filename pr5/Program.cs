using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Введите длину массива: ");
                int a = int.Parse(Console.ReadLine());
                int[] mas = new int[a];
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine($"Введите элемент массива [{i}]");
                    int b = int.Parse(Console.ReadLine());
                    mas[i] = b;
                }
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i] + " ");
                }
                int sum = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    sum += mas[i];
                }
                Console.WriteLine($"Сумма всех элементов: {sum}");
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
    }
}
