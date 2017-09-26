using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Order
    {
        public string customerName;
        public List<MenuItem> items = new List<MenuItem>();

        public double totalPrice
        {
            get
            {
                double calculatedTotal = 0;
                foreach (var item in items)
                {
                    calculatedTotal += item.Price;
                }
                return calculatedTotal;
            }
        }

        public double taxCost
        {
            get => totalPrice * .075;
        }

        public double totalWithTax
        {
            get => totalPrice + taxCost;
        }

    }
}
