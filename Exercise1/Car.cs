using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Car
    {
        private string Brand;
        private int Year;
        private float Price;

        public Car(string brand, int year, float price) 
        {
            Brand = brand;
            Year = year;
            Price = price;
        }
        public void Output()
        {
            Console.WriteLine($"Brand of the car is {Brand}, year of Launch is {Year} and price is {Price}");
        }
    }
}
