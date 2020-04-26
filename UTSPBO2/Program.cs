using System;

namespace UTSPBO2
{
    class RetailItem
    {
        private String description;
        private int unitsOnHand;
        private double price;

        public RetailItem(String x, int y, double z)
        {
            description = x;
            unitsOnHand = y;
            price = z;
        }
        public void setDescription(String x)
        {
            description = x;
        }
        public String getDescription()
        {
            return description;
        }
        public void setUnitsOnHand(int y)
        {
            unitsOnHand = y;
        }
        public int getUnitsOnHand()
        {
            return unitsOnHand;
        }
        public void setPrice(double z)
        {
            price = z;
        }
        public double getPrice()
        {
            return price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RetailItem[] item = new RetailItem[3];

            item[0] = new RetailItem("Jacket", 12, 59.95);
            item[1] = new RetailItem("Jeans", 40, 34.95);
            item[2] = new RetailItem("Shirt", 20, 24.95);

            Console.WriteLine("______________________________________________");
            Console.WriteLine("|\tDescription\tUnits On Hand\tPrice|");
            Console.WriteLine("|____________________________________________|");

            for (int i = 0; i < item.Length; i++)
            {
                Console.WriteLine("|Item " + (i + 1) + "\t" + item[i].getDescription() + "\t\t" + item[i].getUnitsOnHand() + "\t\t" + item[i].getPrice() + "|");
            }
            Console.WriteLine("|____________________________________________|");
            Console.ReadKey();
        }
    }
}

