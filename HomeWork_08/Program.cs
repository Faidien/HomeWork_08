using System;
using System.Collections.Generic;

namespace Task_1
{
    internal class Program
    {
        static int countNum = 100;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<int> list = new List<int>();
            Fill(list);
            Print(list);
            DeleteRangeNum(list);
        }
        static void Fill(List<int> list)
        {
            Random r = new Random();
            for (int i = 0; i < countNum; i++)
            {
                list.Add(r.Next(0, countNum));
            }
        }
        static void Print(List<int> list, string msg = "* * * * * Вывод до удаления * * * * *")
        {
            Console.WriteLine(msg);
            for (int i = 0; i < countNum; i++)
            {
                Console.Write($"\t{i + 1}: {list[i]}");
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void DeleteRangeNum(List<int> list)
        {
            for (int i = 0; i < countNum; i++)
            {
                if (list[i] > 25 && list[i] < 50)
                {
                    list.RemoveAt(i);
                    countNum--;
                }
            }

            Print(list, "* * * * * Вывод после удаления * * * * *");
        }
    }
}
