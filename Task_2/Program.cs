using System;
using System.Collections.Generic;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<long, string> phoneBook = new Dictionary<long, string>();
            GetData(phoneBook);
            FindPhoneNumOwner(phoneBook);
            Console.ReadLine();
        }

        private static void FindPhoneNumOwner(Dictionary<long, string> phoneBook)
        {
            long phoneNum;
            string foundOwner;
            Console.WriteLine("Поиск владельца по номеру телефона");
            Console.Write("Введите телефон(11 символов, только цифры, без знаков): ");
            long.TryParse(Console.ReadLine(), out phoneNum);
            if (phoneBook.TryGetValue(phoneNum, out foundOwner))
                Console.WriteLine($"ФИО владельца телефон: {foundOwner}.");
            else
                Console.WriteLine("По такому номеру телефона владельца не зарегистрировано!");
        }

        private static void GetData(Dictionary<long, string> phoneBook)
        {
            long phoneNum;
            string FIO;
            Console.WriteLine("Ввод данных: ");
            while (true)
            {
                Console.Write("Введите ФИО: ");
                FIO = Console.ReadLine();
                if (FIO != "")
                {
                    Console.Write("Введите телефон(11 символов, только цифры, без знаков): ");
                    long.TryParse(Console.ReadLine(), out phoneNum);
                    try
                    {
                        phoneBook.Add(phoneNum, FIO);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Данный номер уже содержится в телефонной книге!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ввод данных завершен!");
                    break;
                }

            }
        }
    }
}
