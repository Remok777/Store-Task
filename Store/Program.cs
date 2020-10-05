using System;
using System.Linq;
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

            List<Smartphone> Smartphones = new List<Smartphone>
            {
                new Smartphone(1, "Apple iPhone 6s", 399, "8MP", "14``"),
                new Smartphone(2, "Apple iPhone X", 960, "24MP", "18``"),
                new Smartphone(3, "Xiaomi Mi A2", 300, "12MP", "15``"),
                new Smartphone(4, "Huawei 12X", 450, "13MP", "16``"),
            };

            List<int> laptopIds = new List<int>();
            List<int> smartIds = new List<int>();
            int result;

            result = SelectType(Laptops, Smartphones);

            var selectLaptops = Laptops.Select(laptop => laptop.Id);
            foreach ( var item in selectLaptops )
            {
                laptopIds.Add(item);
            }
            var selectSmartphones = Smartphones.Select(smartphone => smartphone.Id);
            foreach (var item in selectLaptops)
            {
                smartIds.Add(item);
            }
            SelectGoods(Laptops, Smartphones, laptopIds, smartIds, result);
        }
        static int SelectType<T, U>(List<T> LapList, List<U> SmartList)
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
        static void SelectGoods<T, U> (List<T> LapList, List<U> SmartList, List<int> lapId, List<int> smartId, int result)
        {
            string number, confirm;
            int res;
            Console.Write("Choose the good you want to buy: ");
            number = Console.ReadLine();
            res = Convert.ToInt32(number);
            if (result == 1)
            {
                for (int i = 0; i < lapId.Count(); i++)
                {
                    if (res == lapId[i])
                    {
                        Console.Clear();
                        Console.WriteLine(LapList[i]);
                    }
                }
            }
            else if (result == 2)
            {
                for (int i = 0; i < smartId.Count(); i++)
                {
                    if (res == smartId[i])
                    {
                        Console.Clear();
                        Console.WriteLine(SmartList[i]);
                    }
                }
            }
            Console.Write("Is it the good you chase? (Y/N): ");
            confirm = Console.ReadLine();
            confirm.ToLower();
            if(confirm == "y")
            {
                Console.WriteLine("Are you sure that you want to buy it? (Y/N)");
                confirm = Console.ReadLine();
                confirm.ToLower();
                if(confirm == "y")
                {
                    string Name, Surname, CardNum, Country, City, PhoneNum;
                    int i = 1;

                    Console.Clear();
                    Console.WriteLine("Please enter payment information");
                    Console.Write("Name: ");
                    Name = Console.ReadLine();
                    Console.Write("Surname: ");
                    Surname = Console.ReadLine();
                    Console.Write("Credit card number: ");
                    CardNum = Console.ReadLine();
                    Console.Write("Destination country: ");
                    Country = Console.ReadLine();
                    Console.Write("Destination city: ");
                    City = Console.ReadLine();
                    Console.Write("Your phone number: ");
                    PhoneNum = Console.ReadLine();
                    List<string> payment = new List<string>()
                    { Name, Surname, CardNum, Country, City, PhoneNum };
                    Console.Clear();
                    Console.WriteLine("Please, check the information you entered");
                    
                    foreach ( var item in payment )
                    {
                        Console.WriteLine($"{i}){item}");
                        i++;
                    }
                }
            }
        }
    }
}
