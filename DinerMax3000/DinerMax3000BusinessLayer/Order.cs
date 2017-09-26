using System.Collections.Generic;

namespace DinerMax3000BusinessLayer
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
