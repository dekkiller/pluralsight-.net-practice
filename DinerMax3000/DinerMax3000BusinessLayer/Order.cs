using System.Collections.Generic;
using DinerMax3000BusinessLayer.dsDinerMax3000TableAdapters;

namespace DinerMax3000BusinessLayer
{
    public class Order
    {
        public string serverName;
        public List<MenuItem> items = new List<MenuItem>();
        private int _databaseID;

        public void AddOrderItemToExistingOrder(string nameOfItem)
        {
            var addOrderItem = new Order_MenuItemTableAdapter();
            var menuItemTable = new MenuItemTableAdapter();
            var menuItemDT = menuItemTable.GetData();
            int menuItemID = 1;

            foreach (dsDinerMax3000.MenuItemRow row in menuItemDT.Rows)
            {
                if (row.Name.ToLower() == nameOfItem.ToLower())
                {
                    menuItemID = row.Id;
                } 
            }

            addOrderItem.InsertOrderItem(_databaseID, menuItemID);

        }

        public static List<Order> GetAllOrders()
        {
            var menuItemTable = new MenuItemTableAdapter();
            var orderTable = new OrderTableAdapter();
            var orderDT = orderTable.GetData();
            var allOrders = new List<Order>();
            foreach (dsDinerMax3000.OrderRow row in orderDT.Rows)
            {
                var currentOrder = new Order();
                currentOrder.serverName = row.ServerName;
                currentOrder._databaseID = row.Id;
                var menuItemDT = menuItemTable.GetOrderItemsByOrderID(row.Id);
                foreach (dsDinerMax3000.MenuItemRow menuRow in menuItemDT.Rows)
                {
                    currentOrder.addMenuItems(menuRow.Name, menuRow.Description, menuRow.Price);
                }
                allOrders.Add(currentOrder);
            }
            return allOrders;
        }

        private void addMenuItems(string Title, string Description, double Price)
        {
            var item = new MenuItem();
            item.Name = Title;
            item.Description = Description;
            item.Price = Price;

            items.Add(item);
        }

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
