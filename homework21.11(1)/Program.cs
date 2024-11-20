using System;
using System.Collections.Concurrent;


namespace tasks
{
    /// <summary>
    /// перечисление дней недели
    /// </summary>
    public enum days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    class Program
    {
        static void Task1()
        {
            //Дана последовательность из 10 чисел.Определить, является ли эта последовательность
            //упорядоченной по возрастанию.В случае отрицательного ответа определить
            //порядковый номер первого числа, которое нарушает данную последовательность.
            //Использовать break.

            Console.WriteLine("задание 1");
            Console.Write("введите 10 чисел: ");
            bool flag = true;
            int[] nums = new int[10];
            while (flag)
            {
                try
                {
                    nums = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray<int>();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("допускается ввод только чисел");
                    continue;
                }
                if (nums.Length != 10) Console.WriteLine("вы ввели не 10 чисел");
                else flag = false;   
            }

            bool flag2 = true;
            for (int i = 0; i < 9; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    Console.WriteLine($"последовательносит нарушается на { i + 2} элементе");
                    flag2 = false;
                    break;
                }
            }
            if (flag2) Console.WriteLine("последовательность упорядоченна");
        }
        static void Task2()
        {
            //Игральным картам условно присвоены следующие порядковые номера в зависимости от
            //их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            //Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
            //«девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство
            //соответствующей карты. Использовать try-catch-finally.
            Console.WriteLine("задание 2");

            Console.Write("введите номер карты: ");
            bool cardFlag = true;
            sbyte? card = null;
            bool formatCheck = true;

            while (cardFlag)
            {
                try
                {
                    card = sbyte.Parse(Console.ReadLine());

                }
                catch (System.FormatException){}
                finally
                {
                    if (card < 14 && card > 6) cardFlag = false;
                    else Console.WriteLine("номер карты больше 5 и меньше 15");
                }
            }
            Console.Write("карта: ");
            switch (card)
            {
                case 11: Console.WriteLine("валет"); break;
                case 12: Console.WriteLine("дама"); break;
                case 13: Console.WriteLine("король"); break;
                case 14: Console.WriteLine("туз"); break;
                default: Console.WriteLine(card); break;

            }

        }

        static void Task3()
        {

            //Напишите программу, которая принимает на входе строку и производит выходные
            //данные в соответствии со следующей таблицей:
            Console.WriteLine("задание 3");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "jabroni": Console.WriteLine("Patron Tequila"); break;
                case "school counselor": Console.WriteLine("Anything with alco"); break;
                case "programmer": Console.WriteLine("hipster craft beer"); break;
                case "bike gang member": Console.WriteLine("moonshine"); break;
                case "politician": Console.WriteLine("your tax dollars"); break;
                case "rapper": Console.WriteLine("blue cristal"); break;
                default: Console.WriteLine("beer"); break;
            }
        }

        static void Task4()
        {
            //Составить программу, которая в зависимости от порядкового номера дня недели(1, 2,
            //..., 7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
            //Использовать enum.

            Console.WriteLine("задание 4");
            Console.Write("введите номер дня недели(1-7) ");
            sbyte day;
            while ((sbyte.TryParse(Console.ReadLine(), out day) == false) || (day > 7) || (day == 0))
            {
                Console.WriteLine("вы ввели неправильное число");
            }
            Console.WriteLine((days)day);

        }

        static void Task5()
        {
            //Создать массив строк.При помощи foreach обойти весь массив.При встрече элемента
            //"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
            //результату.Вывести на экран сколько кукол в “сумке”.

            Console.WriteLine("зажание 5");
            Console.Write("введите несколько предложений через запятую: ");
            string[] purchases = Console.ReadLine().Split(',');
            int bag = 0;
            foreach (string purchase in purchases)
            {
                if (purchase.ToLower() == "barbie doll" || purchase.ToLower() == "hello kitty") bag++;
            }
            Console.WriteLine($"В сумке {bag} кукол");
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
    }
}