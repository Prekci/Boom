using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace М_1_З_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Строка с предложением ввести радиус
            Console.WriteLine("Введите радиус круга:");
            // Объявляется переменная, ей присваивается введенное значение
            // И происходит вывод строки
            string simbol = Console.ReadLine();
            // Попытка преобразования введенной строки в число типа double
            if (double.TryParse(simbol, out double radius))
            {
                // Если число больше нуля
                if (radius > 0)
                {
                    // Объявляется переменная ploshad и ей присвается
                    // Значения высчитываемого выражения
                    // Выводится строка объявляющая площадь окружности и ее значение
                    double ploshad = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"Площадь окружности равна {ploshad}");
                    // Вывод строки
                    Console.ReadLine();
                }
                // Если число меньше нуля
                else
                {
                    // Выводится строка объявляющая
                    // Что радуис не может быть отрицательным
                    Console.WriteLine("Радиус не может быть отрицательным");
                    // Вывод строки
                    Console.ReadLine();
                }
            }
            else
            {
                // Если введенное значение не число
                // То выводится соответствующая строка
                Console.WriteLine("Введенный элемент не соответствует условию");
                // Вывод строки
                Console.ReadLine();
            }
        }
    }
}