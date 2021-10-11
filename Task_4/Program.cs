using System;
using System.IO;
using System.Xml.Serialization;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ФИО: ");
            string FIO = Console.ReadLine();

            Console.Write("Введите улицу: ");
            string street = Console.ReadLine();

            Console.Write("Введите номер дома: ");
            string houseNumber = Console.ReadLine();

            Console.Write("Введите номер квартиры: ");
            string flatNumber = Console.ReadLine();

            Console.Write("Введите мобильный телефон: ");
            string mobilePhone = Console.ReadLine();

            Console.Write("Введите домашний телефон: ");
            string flatPhone = Console.ReadLine();

            Person person1 = new Person(FIO, street, houseNumber, flatNumber, mobilePhone, flatPhone);

            XmlSerializer formatter = new XmlSerializer(typeof(Person));

            using (FileStream fs = new FileStream("people.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person1);
            }

            Console.ReadLine();
        }
    }
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public Adress adress;
        public Phones phones;
        public Person() { }
        public Person(string FIO, string street, string houseNumber, string flatNumber, string mobilePhone, string flatPhone)
        {
            Name = FIO;
            adress = new Adress() { Street = street, FlatNumber = flatNumber, HouseNumber = houseNumber };
            phones = new Phones() { FlatPhone = flatPhone, MobilePhone = mobilePhone };
        }
    }
    [Serializable]
    public struct Adress
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
    }
    [Serializable]
    public struct Phones
    {
        public string MobilePhone { get; set; }
        public string FlatPhone { get; set; }
    }
}
