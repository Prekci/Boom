using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace М_1_З_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Предлогаем ввести имя
            Console.WriteLine("Введите имя");
            // Объявляем переменную name, присваиваем ей введенное значение
            // И выводим на экран 
            string name = Console.ReadLine();
            // Предлогаем ввести фамилию
            Console.WriteLine("Введите фамилию");
            // Объявляем переменную second_name, присваем ей значение
            // И выводим на экран
            string SecondName = Console.ReadLine();
            // Выполняется проверка введенных символов
            if (name.All(char.IsLetter) || SecondName.All(char.IsLetter))
            {
                if (Regex.IsMatch(name, @"[а-я]", RegexOptions.IgnoreCase))
                {
                    if (Regex.IsMatch(SecondName, @"[а-я]", RegexOptions.IgnoreCase)) ;
                    {
                        // Создаются переменные
                        // В веденном слове выделяется первая буква
                        // И преобразуется в верхний регистр
                        string UpName = char.ToUpper(name[0]) + name.Substring(1);
                        string UpSecondName = char.ToUpper(SecondName[0])
                            + SecondName.Substring(1);
                        // Задаем как строка будет выводится на экран
                        Console.WriteLine($"{UpSecondName}, {UpName}");
                        // Вывод на экран
                        Console.ReadLine();
                    }
                }
                else
                {
                    // Если же был введен любой другой символ кроме буквы 
                    // Выведется сообщение об ошибке
                    Console.WriteLine("Введен неправильный элемент. " +
                        "Введите только русские буквы.");
                    // Вывод на экран
                    Console.ReadLine();
                }
            }
            else
            {
                // Если же был введен любой другой символ кроме буквы 
                // Выведется сообщение об ошибке
                Console.WriteLine("Введен неправильный элемент. " +
                    "Введите только буквы.");
                // Вывод на экран
                Console.ReadLine();
            }
        }
    }
}
