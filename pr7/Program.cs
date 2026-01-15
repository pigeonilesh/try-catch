using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Введите длину массивов:");
                int a = int.Parse(Console.ReadLine());
                int[] mas1 = new int[a];
                int[] mas2 = new int[a];
                double[] mas3 = new double[a];
                for (int i = 0; i < mas1.Length; i++)
                {
                    Console.WriteLine($"Введите элемент первого массива [{i}]");
                    mas1[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < mas2.Length; i++)
                {
                    Console.WriteLine($"Введите элемент второго массива [{i}]");
                    mas2[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < mas3.Length; i++)
                {
                    try
                    {
                        mas3[i] = Convert.ToDouble(mas1[i] / mas2[i]);
                        Console.WriteLine($"mas1[{i}] / mas2[{i}] = {mas3[i]:F2}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"Ошибка: Деление на ноль невозможно.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
                    }
                }
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
