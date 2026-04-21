using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoey.Logic
{
    public class InventoryItem
    {

        public String Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; } = false;

        public override string ToString()
        {
            return "Name: " + Name + "Price: " + Price + "Stock: " + Stock + "Sold: " + Sold;
        }


    }
    
}
