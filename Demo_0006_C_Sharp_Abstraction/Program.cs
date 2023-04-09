using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0006_C_Sharp_Abstraction
{
    abstract class Earphone
    {
        private string Brand;
        private int Price;

        public Earphone(string brand, int price)
        {
            this.Brand = brand;
            this.Price = price;
        }
        public string BrandName
        {
            get
            {
                return Brand;
            }
            set
            {
                Brand = value;
            }
        }
        public int PriceValue
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }
        public abstract void GetBrand();
        public abstract void GetPrice();
    }
    class BluetoothEarphone : Earphone
    {
        private int Batteries;
        private int Capacity;
        public BluetoothEarphone(string brand, int price, int batteries, int capacity) : base(brand, price)
        {
            this.Batteries = batteries;
            this.Capacity = capacity;
        }
        public override void GetBrand()
        {
            Console.WriteLine($"The brand name is {BrandName}");
        }
        public override void GetPrice()
        {
            Console.WriteLine($"The price is {PriceValue}");
        }
        public void GetBatteries()
        {
            Console.WriteLine($"Number of batteries are {Batteries}");
        }
        public void GetCapacity()
        {
            Console.WriteLine($"Capacity is {Capacity}");
        }
    }
    class WiredEarphone : Earphone
    {
        public WiredEarphone(string brand, int price) : base(brand, price)
        {

        }
        public override void GetBrand()
        {
            Console.WriteLine($"The brand name is {BrandName}");
        }
        public override void GetPrice()
        {
            Console.WriteLine($"The price is {PriceValue}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WiredEarphone weph = new WiredEarphone("abc", 600);
            weph.GetBrand();
            weph.GetPrice();
            Console.WriteLine();

            BluetoothEarphone beph = new BluetoothEarphone("efg", 1200, 6, 4500);
            beph.GetBrand();
            beph.GetPrice();
            beph.GetBatteries();
            beph.GetCapacity();
            Console.WriteLine();
        }
    }
}
