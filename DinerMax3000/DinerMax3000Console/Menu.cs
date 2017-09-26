using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Menu
    {
        public Menu() // constructor default
        {
            Items = new List<MenuItem>();
        }

        public Menu(string N, List<MenuItem> I) //constructor
        {
            Name = N;
            Items = I;
        }

        public void addMenuItems(string Title, string Description, double Price)
        {
            var item = new MenuItem();
            item.Name = Title;
            item.Description = Description;
            item.Price = Price;

            Items.Add(item);
        }

        public string Name;
        public List<MenuItem> Items;
    }
}
