using System;
using System.Collections.Generic;
namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Laptop> Laptops = new List<Laptop>();
            Laptops.Add(new Laptop { Id = "1", Name = "HP Pavilion Gaming", Price = 900, Ram = 8, Processor = "Intel Core i5-8300H" });
            Laptops.Add(new Laptop { Id = "2", Name = "Asus X509FL-BQ293", Price = 550, Ram = 88, Processor = "Intel Core i5-8265U" });
            Laptops.Add(new Laptop { Id = "3", Name = "Apple MacBook Air", Price = 1200, Ram = 88, Processor = "Intel Core i3" });

            List<Smartphone> Smartphones = new List<Smartphone>();
            Smartphones.Add(new Smartphone{Id = "1", Name = "Apple iPhone 6s", Price = 500, Camera = "8MP", Screen = "14``"});
            Smartphones.Add(new Smartphone{Id = "2", Name = "Apple iPhone X", Price = 960, Camera = "24MP", Screen = "18``"});
            Smartphones.Add(new Smartphone{Id = "3", Name = "Xiaomi Mi A2", Price = 300, Camera = "12MP", Screen = "15``"});
            Smartphones.Add(new Smartphone{Id = "4", Name = "Huawei 12X", Price = 450, Camera = "13MP", Screen = "16``"});

            LaptopSelection<Laptop> select1 = new LaptopSelection<Laptop>();

            select1.SelectType(Laptops);
            string id = "0";
            Console.WriteLine("     Choose the type of electronics:");
            Console.WriteLine("1 - Laptops");
            Console.WriteLine("2 - Smartphones");
            Console.Write("1 or 2: ");
            id = Console.ReadLine();
            if (id == "1")
            {
                Console.Clear();
                Console.WriteLine("                       Laptops");

                foreach (var laptop in Laptops)
                {
                    Console.WriteLine($"{laptop.Id} | {laptop.Name} | {laptop.Price} | {laptop.Ram} | {laptop.Processor} |");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("                    Smartphones");

                foreach (var smartphone in Smartphones)
                {
                    Console.WriteLine($"{smartphone.Id} | {smartphone.Name} | {smartphone.Price} | {smartphone.Camera} | {smartphone.Screen} |");
                }
            }
        }
    }
}
