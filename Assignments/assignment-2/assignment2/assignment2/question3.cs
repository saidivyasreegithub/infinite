using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class SaleDetails
    {
        private int salesNo;
        private int productNo;
        private double prices;
        private DateTime dateOfSale;
        private int qty;
        private double totalAmount;

        public SaleDetails(int salesNumber, int productNumber, double unitPrices, int quantity, DateTime SaleDate)
        {
            salesNo = salesNumber;
            productNo = productNumber;
            prices = unitPrices;
            qty = quantity;
            dateOfSale = SaleDate;
            Sales();
        }
        public void Sales()
        {
            totalAmount = qty * prices;
        }
        public void ShowData()
        {
            Console.WriteLine($"Sales No:{salesNo}");
            Console.WriteLine($"Product No:{productNo}");
            Console.WriteLine($"Prices:{prices}");
            Console.WriteLine($"Qty:{qty}");
            Console.WriteLine($" Date of Sale:{dateOfSale}");
            Console.WriteLine($"Total Amount:{totalAmount}");
        }

    }
    class question3
    {
        static void Main(string[] args)
        {
            int saleNumber = 1;
            int productNumber = 101;
            double unitPrices = 10.32;
            DateTime saleDate = DateTime.Now;
            int quatity = 5;
            SaleDetails s = new SaleDetails(saleNumber, productNumber, unitPrices, quatity, saleDate);
            s.ShowData();

        }
    }
}

