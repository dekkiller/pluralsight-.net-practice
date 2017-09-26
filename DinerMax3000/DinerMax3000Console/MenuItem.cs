using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class MenuItem
    {
        public string Name;
        // in real world use decimal, more exact for currency usages
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0) //if value <0 by mistake then we can avoid free items
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("You've made a pricing error!");
                }
            }
        }
        public string Description { get; set; }

        private double _price; //shadow property

    }
}
