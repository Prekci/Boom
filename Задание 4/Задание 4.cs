using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем переменную для генерации случайных чисел
            Random RandomMassive = new Random();
            // Создаем массив для хранения 20 случайных чисел
            int[] massive = new int[20];
            // Заполняем массив случайными числами от 1 до 100
            for (int i = 0; i < massive.Length; i++)
            {
                // Генерируем случайное число от 1 до 100
                massive[i] = RandomMassive.Next(1, 101); 
            }
            // Объявляем переменные для хранения максимального и минимального значений
            // Предполагая, что первый элемент массива - их начальные значения
            int max = massive[0];
            int min = massive[0];   
            // Перебираем все элементы массива, чтобы найти максимальное и минимальное значения
            foreach (int num in massive)
            {
                // Если текущее число больше текущего максимального значения, обновляем максимум
                max = Math.Max(max, num);
                // Если текущее число меньше текущего минимального значения, обновляем минимум
                min = Math.Min(min, num);
            }            
            // Выводим все числа, разделенные пробелом
            Console.WriteLine("Массив случайных чисел:\n" + string.Join(" ", massive)); 
            // Выводим максимальное значение
            Console.WriteLine($"Максимальное значение: {max}");
            // Выводим минимальное значение
            Console.WriteLine($"Минимальное значение: {min}");
            // Выводим результаты на экран
            Console.ReadLine();
        }
    }
}
