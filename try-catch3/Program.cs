using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());
                if (age < 0)
                {
                    throw new Exception();
                }
                Console.WriteLine("Возвраст принят: " + age);
            }
            catch
            {
                Console.WriteLine($"Ошибка! Возвраст не должен быть отрицательным.");
            }
        }
    }
}
