using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoey.Logic
{

    public class CartItem
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal Subtotal => Quantity * Price;
    }

    public static class CartManager
    {
        public static List<CartItem> Basket = new List<CartItem>();

        public static void AddItem(CartItem item)
        {
            var exisiting = Basket.FirstOrDefault(x => x.ProductID == item.ProductID);

            if(exisiting != null)
            {
                exisiting.Quantity += item.Quantity;
            }
            else
            {
                Basket.Add(item);
            }
        }

        public static void Clear()
        {
            Basket.Clear();
        }
    }
}
