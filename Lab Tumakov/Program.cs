using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4.1");
            // Написать программу, которая читает с экрана число от 1 до 365 (номер дня
            // в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует 9
            // февраля(високосный год не учитывать).
            Console.WriteLine("Введите номер дня в году (от 1 до 365):");
            int dayvgodu;
            if (int.TryParse(Console.ReadLine(), out dayvgodu) && dayvgodu >= 1 && dayvgodu <= 365)
            {
                DateTime date = new DateTime(2023, 1, 1).AddDays(dayvgodu - 1);
                Console.WriteLine($"День {dayvgodu} соответствует: {date.ToString("d MMMM")}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректное число.");
            }
            Console.WriteLine("Задание 4.2");
            // Добавить к задаче из предыдущего упражнения проверку числа введенного
            // пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
            // исключение, и выдавать на экран сообщение.
            Console.WriteLine("Введите номер дня в году (от 1 до 365):");
            int dneyvgodu;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out dneyvgodu) || dneyvgodu < 1 || dneyvgodu > 365)
                {
                    throw new ArgumentOutOfRangeException("dneyvgodu", "Ошибка: Номер дня должен быть в диапазоне от 1 до 365.");
                }

                DateTime date = new DateTime(2023, 1, 1).AddDays(dneyvgodu - 1);
                Console.WriteLine($"День {dneyvgodu} соответствует: {date.ToString("d MMMM")}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Ввод должен быть числом.");
            }
            Console.WriteLine("Задание 4.3");
            // Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
            // учитывала год(високосный или нет). Год вводится с экрана. (Год високосный, если он
            // делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
            // год.Однако, если он делится без остатка на 400, это високосный год.)
            Console.WriteLine("Введите год:");
            int year;
            try
            {
                year = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Ввод должен быть числом.");
                return;
            }
            Console.WriteLine("Введите номер дня в году (от 1 до 365):");
            int dayYear;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out dayYear) || dayYear < 1 || dayYear > (IsLeapYear(year) ? 366 : 365))
                {
                    throw new ArgumentOutOfRangeException("dayOfYear", "Ошибка: Номер дня должен быть в диапазоне от 1 до " + (IsLeapYear(year) ? 366 : 365) + ".");
                }
                DateTime date = new DateTime(year, 1, 1).AddDays(dayYear - 1);
                Console.WriteLine($"День {dayYear} в году {year} соответствует: {date.ToString("d MMMM")}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
