using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace М_1_З_1
{
    internal class Program
    {
        static void Main()
        {
            // Выводим предложение ввести число
            Console.WriteLine("Введите число:"); 
            // Считываем введенную строку
            string simbol = Console.ReadLine(); 
            // Попытка преобразования введенной строки в число типа double    
            // Если успешно, значение будет храниться в переменной 'number'
            if (double.TryParse(simbol, out double number))                                                                                    
            {
                // Проверяем является ли число четным
                if (2 == 0) 
                {                   
                    // Если число четное выводится сообщение о четности  
                    Console.WriteLine("Введенное число четное"); 
                    Console.ReadLine();
                }
                else
                {
                    // Если нет вывод сообщение о нечетности
                    Console.WriteLine("Введенное число нечетное."); 
                    Console.ReadLine();
                }
            }
            else
            {   // Если не удалось преобразовать введенную строку в число
                // Выводим сообщение об ошибке             
                Console.WriteLine("Введенное значение не является числом.");  
                Console.ReadLine();                                          
            }
        }
    }
}
