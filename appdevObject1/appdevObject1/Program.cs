using System;

namespace appdevObject1
{
    class iPhone: CellPhone //subclass that inherits all the methods etc from CellPhone
    {
        public string colour = "gold";
        private string model = "Iphone";
        int phonePrice;
        public new string Model //polymorphic method
        {

            get //remove to make it Write only
            {
                return model;
            }
        }
        public override int PhonePrice()
        {
            phonePrice = 2000;
            return phonePrice;
        }

    }
    class CellPhone
    {
        public string brandName = "Samsung";
        int phonePrice;

        private int storage;
        private string model; //automatic properties

        public int Storage //its PROPERTY time
        {
            set //remove set to make it read only
            {
                storage = value;
            }
            get //remove to make it Write only
            {
                return storage;
            }
        }
        public string Model //its PROPERTY time
        {
            set //remove set to make it read only
            {
                model = value;
            }
            get //remove to make it Write only
            {
                return model;
            }
        }


        public CellPhone()
         {
            phonePrice = 1200;
            Console.WriteLine("Demo of Constructor");
        }
        public CellPhone(int sampleText)
        {
            phonePrice = 1400;
            brandName = "Apple";
            Console.WriteLine("Demo of overloaded Constructor");
        }

        public virtual int PhonePrice()
        {
            return phonePrice;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            iPhone MyCell = new iPhone();
            Console.WriteLine("The brand of phone is: " + MyCell.brandName);
            int phonePrice = MyCell.PhonePrice();
            Console.WriteLine($"The price of the phone is ${phonePrice}");

            CellPhone MyOverCell = new CellPhone(12);
            Console.WriteLine("The brand of phone is: " + MyOverCell.brandName);
            int phonePriceOver = MyOverCell.PhonePrice();
            Console.WriteLine($"The price of the phone is ${phonePriceOver}");


            MyCell.Storage = 512;

            Console.WriteLine($"the model is: {MyCell.Model} and it has {MyCell.Storage}mb of storage and is the color {MyCell.colour}");
        }
    }
}
