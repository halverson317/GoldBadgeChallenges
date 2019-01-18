using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuItems
    {
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string Ingredients { get; set; }
        public decimal ItemPrice { get; set; }

        public MenuItems(int itemNumer, string itemName, string itemDescription, string ingredients, decimal itemPrice)
        {
            ItemNumber = ItemNumber;
            ItemName = itemName;
            ItemDescription = itemDescription;
            Ingredients = ingredients;
            ItemPrice = itemPrice;
        }

        public MenuItems()
        {

        }
    }
}
