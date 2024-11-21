using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_Rais_Fazylov
{
    internal class Program
    {
        enum DayOfWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static string Drink(string input)
        {
            switch (input.ToLower())
            {
                case "jabroni":
                    return "Patron Tequila";
                case "school counselor":
                    return "Anything with Alcohol";
                case "programmer":
                    return "Hipster Craft Beer";
                case "bike gang member":
                    return "Moonshine";
                case "politician":
                    return "Your tax dollars";
                case "rapper":
                    return "Cristal";
                default:
                    return "Beer";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            // Дана последовательность из 10 чисел. Определить, является ли эта последовательность
            // упорядоченной по возрастанию.В случае отрицательного ответа определить
            // порядковый номер первого числа, которое нарушает данную последовательность.
            // Использовать break.
            int[] num = new int[10];
            Console.WriteLine("Введите 10 чисел:");
            for (int i = 0; i < 10; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            bool iy = true;
            int fi = -1;

            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] > num[i + 1])
                {
                    iy = false;
                    fi = i + 1;
                    break;
                }
            }
            if (iy)
            {
                Console.WriteLine("Последовательность упорядочена");
            }
            else
            {
                Console.WriteLine($"Последовательность не упорядочена. Первое нарушение на позиции: {fi}");
            }
            Console.WriteLine("Задание 2");
            // Игральным картам условно присвоены следующие порядковые номера в зависимости от
            // их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            // Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
            // «девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство
            // соответствующей карты. Использовать try-catch-finally.
            int k;
            string card = string.Empty;
            Console.WriteLine("Введите порядковый номер карты (6 <= k <= 14):");
            try
            {
                k = int.Parse(Console.ReadLine());

                if (k < 6 || k > 14)
                {
                    throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14.");
                }
                switch (k)
                {
                    case 6:
                        card = "Шестёрка";
                        break;
                    case 7:
                        card = "Семёрка";
                        break;
                    case 8:
                        card = "Восьмёрка";
                        break;
                    case 9:
                        card = "Девятка";
                        break;
                    case 10:
                        card = "Десятка";
                        break;
                    case 11:
                        card = "Валет";
                        break;
                    case 12:
                        card = "Дама";
                        break;
                    case 13:
                        card = "Король";
                        break;
                    case 14:
                        card = "Туз";
                        break;
                }

                Console.WriteLine($"Достоинство карты: {card}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Ввод должен быть числом.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine("Задание 3");
            // Напишите программу, которая принимает на входе строку и производит выходные
            // данные в соответствии со следующей таблицей: *таблица
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string output = Drink(input);
            Console.WriteLine($"Рекомендуемый напиток: {output}");
            Console.WriteLine("Задание 4");
            // Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
            // ...,7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
            // Использовать enum.
            Console.WriteLine("Введите порядковый номер дня недели (1-7):");
            int dayNum;
            if (int.TryParse(Console.ReadLine(), out dayNum) && dayNum >= 1 && dayNum <= 7)
            {
                DayOfWeek day = (DayOfWeek)dayNum;
                Console.WriteLine($"День недели: {day}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректный номер дня недели (1-7).");
            }
            Console.WriteLine("Задание 5");
            // Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
            // "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
            // результату.Вывести на экран сколько кукол в “сумке”.
        }
    }
}
