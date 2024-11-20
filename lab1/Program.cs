using System;

class Program
{
    //        Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365(номер дня
    //в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
    //февраля(високосный год не учитывать).
    static void Task1() 
    {
        Console.WriteLine("упражнение 4.1");
        Console.Write("Введите номер дня в году (от 1 до 365): ");
        int dayOfYear = int.Parse(Console.ReadLine());
        DateSerching(dayOfYear);
    }

//    Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
//пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
//исключение, и выдавать на экран сообщение.
    static void Task2()
    {
        Console.WriteLine("упражнение 4.2");
        int dayOfYear;
        do
        {
            Console.Write("Введите номер дня в году (от 1 до 365): ");
        }
        while (!int.TryParse(Console.ReadLine(), out dayOfYear) || dayOfYear >= 365 || dayOfYear <= 1);
        DateSerching(dayOfYear);
    }

    //Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
    //учитывала год(високосный или нет). Год вводится с экрана. (Год високосный, если он
    //делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
    //год. Однако, если он делится без остатка на 400, это високосный год.)
    static void Task3()
    {
        Console.WriteLine("дз 4.1");
        int dayOfLeapYear, year;
        Console.Write("Введите год: ");
        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("допускается ввод только чисел");
        }
        Console.Write("Введите день: ");
        while (!int.TryParse(Console.ReadLine(), out dayOfLeapYear) || dayOfLeapYear >= 365 || dayOfLeapYear <= 1)
        {
            Console.WriteLine("введите число от 1 до 366");
        }
        DateSerching(dayOfLeapYear, year);
    }

    /// <summary>
    /// поиск числа и месяца
    /// </summary>
    static void DateSerching(int dayOfYear)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int month = 0;
        int dayOfMonth = dayOfYear;

        for (int i = 0; i < daysInMonth.Length; i++)
        {
            if (dayOfMonth > daysInMonth[i])
            {
                dayOfMonth -= daysInMonth[i];
            }
            else
            {
                month = i + 1;
                break;
            }
        }

        Console.WriteLine($"{dayOfMonth} {GetMonthName(month)}.");
    }

    /// <summary>
    /// метод по поиску числа и месяца в високосном году
    /// </summary>
    static void DateSerching(int dayOfYear, int year)
    {
        sbyte[] daysInMonth = new sbyte[12];

        if ((year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0)))
        {
            daysInMonth = [31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
        }
        else daysInMonth = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
        int month = 0;
        int dayOfMonth = dayOfYear;

        for (int i = 0; i < daysInMonth.Length; i++)
        {
            if (dayOfMonth > daysInMonth[i])
            {
                dayOfMonth -= daysInMonth[i];
            }
            else
            {
                month = i + 1;
                break;
            }
        }

        Console.WriteLine($"{dayOfMonth} {GetMonthName(month)}.");
    }

    /// <summary>
    /// метод выдает месяц соотвествующему числу
    /// </summary>
    static string GetMonthName(int month)
    {
        switch (month)
        {
            case 1: return "января";
            case 2: return "февраля";
            case 3: return "марта";
            case 4: return "апреля";
            case 5: return "мая";
            case 6: return "июня";
            case 7: return "июля";
            case 8: return "августа";
            case 9: return "сентября";
            case 10: return "октября";
            case 11: return "ноября";
            case 12: return "декабря";
            default: return "";
        }
    }
    static void Main(string[] args)
    {
//        Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365(номер дня
//в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
//февраля(високосный год не учитывать).

        Task1();

//        Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
//пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
//исключение, и выдавать на экран сообщение.
        Task2();

//        Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
//учитывала год(високосный или нет). Год вводится с экрана. (Год високосный, если он
//делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
//год.Однако, если он делится без остатка на 400, это високосный год.)
        Task3();
    }
}
