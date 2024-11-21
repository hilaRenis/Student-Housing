using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class ManageShoppingList
    {
        private List<ShoppingItem> itemList;

        public ManageShoppingList()
        {
            itemList = new List<ShoppingItem>();
        }

        public void AddItem(string ItemName, decimal ItemCost)
        {
            ShoppingItem Item = new ShoppingItem(ItemName, ItemCost);
            itemList.Add(Item);
        }

        public void RemoveItem(int ItemIndex)
        {
            itemList.RemoveAt(ItemIndex);
        }

        public List<ShoppingItem> ItemList
        {
            get
            {
                return itemList;
            }
        }
    }
}
