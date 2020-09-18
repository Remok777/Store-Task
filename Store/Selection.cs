using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class LaptopSelection<T> : Laptop where T : class 
    {  
        public void SelectType(List<T> laptop)
        {
            foreach (var lap in laptop)
            {
                Console.WriteLine($"{laptop[0]}");
            }
            
        }
    }
}
