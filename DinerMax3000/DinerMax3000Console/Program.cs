using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var orderFive = new Order();

//            foreach (var item in summerMenu.Items)
//            {
//                orderFive.items.Add(item);
//            }

            for (int i = 0; i < summerMenu.Items.Count; i++)
            {
                orderFive.items.Add(summerMenu.Items[i]);
            }
       

//            foreach (var item in orderFive.items)
//            {
//                Console.WriteLine(item.Name);
//            }

        }
    }
}
