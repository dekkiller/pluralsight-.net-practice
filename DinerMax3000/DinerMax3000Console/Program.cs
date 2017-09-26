using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000BusinessLayer;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";

            summerMenu.addMenuItems("Steak", "A1 steak", 55.99);
            summerMenu.addMenuItems("Taco", "fresh taco", 5.50);

            var outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Don't drink and drive.";
            outsideDrinks.addMenuItems("IPA", "IPA Beverage", 10.99);
            outsideDrinks.addMenuItems("pina colada", "no more worries", 9.75);
            try
            {
                outsideDrinks.addMenuItems("Screwdriver", "dont drink this", 0);
            }
            catch (Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
//                throw; // This throws exception if price <= 0 which it will in this case b/c item price is 0
            }

//          outsideDrinks.addMenuItems("Screwdriver", "dont drink this", 0);

            var orderFive = new Order();

//            foreach (var item in summerMenu.Items)
//            {
//                orderFive.items.Add(item);
//            }

            for (int i = 0; i < summerMenu.Items.Count; i++)
            {
                orderFive.items.Add(summerMenu.Items[i]);
            }

            Console.WriteLine(orderFive.totalPrice);
            Console.WriteLine(orderFive.taxCost);
            Console.WriteLine(orderFive.totalWithTax);
       

            foreach (var item in orderFive.items)
            {
                Console.WriteLine("Item: " + item.Name + " Price: " + item.Price);
            }

        }
    }
}
