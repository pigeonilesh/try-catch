using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"введите число строк и столбцов");
            int a = int.Parse(Console.ReadLine());
            int[,] mas = new int[a, a];
            int kol = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.WriteLine($"Введите элемент массива [{i}], [{j}]]");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(mas[i, j] + " ");
                    if (i != j)
                    {
                        kol++;
                    }
                }
                Console.WriteLine();
            }
            int par = 0;
            for (int i = 0;i < a; i++)
            {
                for (int j = 0;j < a; j++)
                {
                    if (mas[i, j] == mas[j, i] && i != j)
                    {
                        par++;  
                    }
                }
            }
            if (par == kol)
            {
                Console.WriteLine($"Yes");
            }
            else
                Console.WriteLine($"No");
        }
    }
}
