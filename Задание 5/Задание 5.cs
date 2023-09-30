using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Предлагаем ввести число
            Console.WriteLine("Введите возраст:");
            // Присваиваем переменной simbol значение и выводим на экран
            string simbol = Console.ReadLine();
            // Преобразовываем строку в число типа double
            if (double.TryParse(simbol, out double age))
            {
                // Проверяем число на соответствие условию
                if (age >= 18)
                {
                    // Если соответствует выводим на данное сообщение
                    Console.WriteLine("Вы можете получить права");
                    // Выводим на экран
                    Console.ReadLine();
                }
                // Если не соответствует
                else
                {
                    // Выводим это сообщение
                    Console.WriteLine("Вы не можете получить права");
                    // Выводим на экран
                    Console.ReadLine();
                }
            }
            // Если было введено что то кроме числа
            else
            {
                // Выводим сообщение о некоректно введнном элементе
                Console.WriteLine("Введите корректное значение");
                // Выводим на экран
                Console.ReadLine();
            }
        }
    }
}
