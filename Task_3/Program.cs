using System;
using System.Collections.Generic;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> ts = new HashSet<int>();
            while (true)
            {
                int phoneNum;
                Console.Write("Введите число (для выхода нажать любой символ кроме цифр): ");
                try
                {
                    phoneNum = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ввод цифр завершен!");
                    break;
                }
                if (ts.Add(phoneNum))
                {
                    Console.WriteLine("Число успешно сохранено");
                }
                else
                {
                    Console.WriteLine("Число уже вводилось ранее!");

                }
            }

            Console.ReadLine();
        }
    }
}
