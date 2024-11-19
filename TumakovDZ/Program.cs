using System;

namespace TumakovDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1, 4.2\n"); //просто получидлось так что сделал сразу с проверкой числа не читая 4.2

            Console.WriteLine("Введите номер дня в году (от 1 до 365):");
            Int16 vvedeno = Int16.Parse(Console.ReadLine());
            if (vvedeno < 1 || vvedeno > 365 || vvedeno == 0)
            {
                Console.WriteLine("Неверно!!!!!, давай по новой");
                vvedeno = Int16.Parse(Console.ReadLine());
            }
            Byte[] daysVmes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
            int denVmes = vvedeno;
            int nomMes = 0;
            while (denVmes > daysVmes[nomMes])
            {
                denVmes -= daysVmes[nomMes];
                nomMes++;
            }
            Console.WriteLine($"Это {denVmes} {monthNames[nomMes]}");

            Console.WriteLine("\nДЗ 4.1\n");

            Console.WriteLine("Введите год:");
            Int16 god = Int16.Parse(Console.ReadLine());
            if ((god % 400 ) == 0)
            {
                Console.WriteLine("Високосный");
            }
            else if ((god % 4) == 0 & (god % 100) != 0)
            {
                Console.WriteLine("Високосный");
            }
            else
            {
                Console.WriteLine("Не високосный");
            }


            Console.ReadKey();
        }
    }
}
