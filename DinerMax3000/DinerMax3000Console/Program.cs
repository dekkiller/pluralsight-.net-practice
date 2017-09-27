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
            //            var summerMenu = new FoodMenu();
            //            summerMenu.Name = "Summer Menu";
            //
            //            summerMenu.addMenuItems("Steak", "A1 steak", 55.99);
            //            summerMenu.addMenuItems("Taco", "fresh taco", 5.50);
            //
            //            var outsideDrinks = new DrinkMenu();
            //            outsideDrinks.Disclaimer = "Don't drink and drive.";
            //            outsideDrinks.addMenuItems("IPA", "IPA Beverage", 10.99);
            //            outsideDrinks.addMenuItems("pina colada", "no more worries", 9.75);
            //            try
            //            {
            //                outsideDrinks.addMenuItems("Screwdriver", "dont drink this", 0);
            //            }
            //            catch (Exception thrownException)
            //            {
            //                Console.WriteLine(thrownException.Message);
            ////                throw; // This throws exception if price <= 0 which it will in this case b/c item price is 0
            //            }
            //
            ////          outsideDrinks.addMenuItems("Screwdriver", "dont drink this", 0);
            /// 
            /// 

            List<Menu> menusFromDB = Menu.GetAllMenus();
            Menu firstMenu = menusFromDB[0];
            firstMenu.SaveMenuItem("Quiche", "Combination of cheese and sauce", 11.99);
            menusFromDB = Menu.GetAllMenus();
            Console.WriteLine("-------------------------------");
//            var orderFive = new Order();
//
//            foreach (var menuinDB in menusFromDB)
//            {
//                foreach (var menuitem in menuinDB.Items)
//                {
//                    orderFive.items.Add(menuitem);
//                }
//            }


//            for (int i = 0; i < summerMenu.Items.Count; i++)
//            {
//                orderFive.items.Add(summerMenu.Items[i]);
//            }

//            Console.WriteLine("Total Price of items: " + orderFive.totalPrice);
//            Console.WriteLine("Total Price of tax: " + orderFive.taxCost);
//            Console.WriteLine("Total Price of meal: " + orderFive.totalWithTax);
//       
//
//            foreach (var item in orderFive.items)
//            {
//                Console.WriteLine("Item: " + item.Name + " Price: " + item.Price);
//            }
//            Console.ReadKey();

            var ordersFromDB = Order.GetAllOrders();
            Order firstOrder = ordersFromDB[0];
            foreach (var order in ordersFromDB)
            {
                Console.WriteLine("Server Name: " + order.serverName);
                foreach (var menuitem in order.items)
                {
                    Console.WriteLine("Item Name: " + menuitem.Name + " " + menuitem.Price);
                }
                Console.WriteLine("Total Price of items: " + order.totalPrice);
                Console.WriteLine("Total Price of tax: " + order.taxCost);
                Console.WriteLine("Total Price of meal: " + order.totalWithTax + "\n");
            }
            //firstOrder.AddOrderItemToExistingOrder("taco");
            //firstOrder.AddOrderItemToExistingOrder("pizone");
//            testing addorderitem
            foreach (var order in ordersFromDB)
            {
                Console.WriteLine("Server Name: " + order.serverName);
                foreach (var menuitem in order.items)
                {
                    Console.WriteLine("Item Name: " + menuitem.Name + " " + menuitem.Price);
                }
                Console.WriteLine("Total Price of items: " + order.totalPrice);
                Console.WriteLine("Total Price of tax: " + order.taxCost);
                Console.WriteLine("Total Price of meal: " + order.totalWithTax +"\n");
            }

        }
    }
}
