using System;
using System.Security.Cryptography;

namespace FileDZ
{
    internal class Program
    {
        enum Week
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1\n");

            Console.WriteLine("Введите возрастающую последовательность из 10 чисел");
            int[] numbers = new int[10];
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Введите число: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 9; i++)
            {
                if (numbers[i+1] < numbers[i])
                {
                    Console.WriteLine("Неверная последовательность!!!");
                    break;
                }
            }
            Console.WriteLine("\nЗадание 2\n");

            try
            {
                Console.Write("Введите номер карты (6-14): ");
                Byte k = Byte.Parse(Console.ReadLine());
                string cardName;
                switch (k)
                {
                    case 6:
                        cardName = "Шестерка";
                        break;
                    case 7:
                        cardName = "Семерка";
                        break;
                    case 8:
                        cardName = "Восьмерка";
                        break;
                    case 9:
                        cardName = "Девятка";
                        break;
                    case 10:
                        cardName = "Десятка";
                        break;
                    case 11:
                        cardName = "Валет";
                        break;
                    case 12:
                        cardName = "Дама";
                        break;
                    case 13:
                        cardName = "Король";
                        break;
                    case 14:
                        cardName = "Туз";
                        break;
                    default:
                        cardName = "Ошибка"; 
                        break;
                }

                Console.WriteLine($"Это карта: {cardName}");
            }
            
            finally
            {
                Console.WriteLine("Программа завершена.");
            }

            Console.WriteLine("\nЗадание 3\n");

            Console.WriteLine("Введите на английском языке общность людей чтобы узнать что они предпочитают пить");
            string input = Console.ReadLine();
            string nuznoe = input.ToLower();

            try
            {
                string result = GetOutput(nuznoe);
                    
                Console.WriteLine($"Нужно пить: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"мммм: {ex.Message}");
            }

            Console.WriteLine("\nЗадание 4\n");

            Console.WriteLine("Введите порядковое число дня недели (1-7):");
            Byte den = Byte.Parse(Console.ReadLine());
            var dayName = Enum.GetName(typeof(Week), den - 1);
            Console.WriteLine($"Название дня недели: {dayName}");

            Console.WriteLine("\nЗадание 5\n");

            string[] toys = { "Hello Kitty", "Barbie doll", "Lego", "Transformers", "Hello Kitty", "Superman", "Barbie doll" };
            int cnt = 0;

            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    cnt++;
                }
            }

            Console.WriteLine($"Количество кукол в сумке: {cnt}");

            Console.ReadKey();
        }
        static string GetOutput(string input)
    {
        switch (input)
        {
            case "jabroni":
                return "Patron Tequila";
            case "school counselor":
                return "Anything with Alcohol";
            case "programmer":
                return "Hipster Craft Beer";
            case "bike gang member":
                return "MoonShine";
            case "politician":
                return "Your tax dollars";
            case "rapper":
                return "Cristal";
            default:
                return "Beer";
        }
    }
    }
}
