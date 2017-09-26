using System.Collections.Generic;
using DinerMax3000BusinessLayer.dsDinerMax3000TableAdapters;

namespace DinerMax3000BusinessLayer
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

        public static List<Menu> GetAllMenus()
        {
            var menuItemTable = new MenuItemTableAdapter();
            var menuTable = new MenuTableAdapter();
            var dtMenu = menuTable.GetData();
            List<Menu> allMenus = new List<Menu>();
            foreach (dsDinerMax3000.MenuRow row in dtMenu.Rows)
            {
                var currentMenu = new Menu();
                currentMenu.Name = row.Name;
                //allMenus.Add(currentMenu);
                var dtMenuItems = menuItemTable.GetMenuItemsByMenuID(row.Id);
                foreach (dsDinerMax3000.MenuItemRow menuItemRow in dtMenuItems)
                {
                    currentMenu.addMenuItems(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);
                }
                allMenus.Add(currentMenu);
            }
            return allMenus;


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
