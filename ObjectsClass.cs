using System.Collections;
using UnityEngine;

namespace InventoryList
{
    [System.Serializable]
    public class Item
    {
        public string ItemName;
        public int ItemPrice;
        public string ItemDescription;

        public Item()
        {

        }

        public Item(string itemName, int itemPrice, string itemDescription)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            ItemDescription = itemDescription;
        }
    }
}