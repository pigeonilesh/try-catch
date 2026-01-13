using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Введите первое число: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine($"Введите второе число: ");
                int b = int.Parse(Console.ReadLine());
                int result = a / b;
                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Ошибка: Деление на ноль невозможно.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Ошибка: Возможен только ввод чисел.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла неизвестная ошибка: {ex.Message}");
            }
        }
    }
}
