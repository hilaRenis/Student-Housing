using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class ShoppingItem
    {
        private string itemName;
        private decimal itemCost;

        public ShoppingItem(string itemName, decimal itemCost)
        {
            this.itemName = itemName;
            this.itemCost = itemCost;
        }

        public string GetInfo()
        {
            string Info = $"{itemName} - {itemCost}";
            return Info;
        }
    }
}
