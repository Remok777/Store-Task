using System;
using System.Collections.Generic;
namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Laptop> Laptops = new List<Laptop>
            {
                new Laptop(1, "HP Pavilion Gaming", 900, 8, "Intel Core i5-8300H"),
                new Laptop(2, "Asus X509FL-BQ293", 550, 6, "Intel Core i5-8265U"),
                new Laptop(3, "Apple MacBook Air", 1200, 8, "Intel Core i3")
            };

            Dictionary<int, Smartphone> Smartphones = new Dictionary<int, Smartphone>();
            Smartphones.Add(1, new Smartphone(1, "Apple iPhone 6s", 399, "8MP", "14``"));
            Smartphones.Add(2, new Smartphone(2, "Apple iPhone X", 960, "24MP", "18``"));
            Smartphones.Add(3, new Smartphone(3, "Xiaomi Mi A2", 300, "12MP", "15``"));
            Smartphones.Add(4, new Smartphone(4, "Huawei 12X", 450, "13MP", "16``"));

            int result;

            result = SelectType(Laptops, Smartphones);
            Select(Laptops, Smartphones, result);
        }
        static int SelectType<T, U>(List<T> LapList, Dictionary<int, U> SmartList)
        {
            string number;
            int res;
            Console.WriteLine("     Select the type of electronics:");
            Console.WriteLine("1 - Laptops");
            Console.WriteLine("2 - Smartphones");
            Console.Write("Type 1 or 2: ");
            number = Console.ReadLine();
            res = Convert.ToInt32(number);
            if(res == 1)
            {
                foreach (var lap in LapList)
                {
                    Console.WriteLine($"{lap}");
                }
            }
            else if (res == 2)
            {
                foreach (var smart in SmartList)
                {
                    Console.WriteLine($"{smart}");
                }
            }
            else
            {
                Console.Write("Input is uncorrect");
            }
            return res;
        }
        static void Select<T, U> (List<T> LapList, Dictionary<int, U> SmartList, int choice)
        {
            if(choice == 1)
            {
                Console.WriteLine($"{LapList[1]}");
            }
        }
    }
}
