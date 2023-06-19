using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace InventoryList
{
    public class Backpack : MonoBehaviour
    {
        public int MaxItems = 5;
        public List<string> BackpackInventory = new();

        private ItemList InventoryItems;
        public GameObject ItemManager;

        public TMP_Text InventoryText;
        public TMP_Text Inventoryitems;

        public int InventoryCount;
     
        private void Start()
        {
            InventoryItems = ItemManager.GetComponent<ItemList>();

            AddInventory();
            Inventoryitems.text = ListToText(BackpackInventory);
        }

        public void AddInventory()
        {
            if (InventoryCount < MaxItems)
            {                
                BackpackInventory.Add(InventoryItems.ItemInventory[0].ItemName);
                BackpackInventory.Add(InventoryItems.ItemInventory[8].ItemName);
                BackpackInventory.Add(InventoryItems.ItemInventory[15].ItemName);
            }
            else
            {
                Debug.Log("Inventory is full");
            }
        }

        private void Update()
        {
            InventoryCount = BackpackInventory.Count;
            InventoryText.text = InventoryCount.ToString();

        }
        private string ListToText(List<string> List)
        {
            string result = "";
            foreach (var listMember in BackpackInventory)
            {
                result += listMember.ToString() + "\n";
            }
         
            return result;
        }

        public void OrganiseBackpack()
        {
            BackpackInventory.Sort();
            Inventoryitems.text = ListToText(BackpackInventory);
        }
         public GameObject Background;
         public Sprite BackgroundImage1;
         public Sprite BackgroundImage2;
         public Sprite BackgroundImage3;

        public void DropdownInpout(int Value)
        {
            if (Value == 0)
            {
               Image image = Background.GetComponent<Image>();
                image.sprite = BackgroundImage1;
            }
            if (Value == 1) 
            {
                Image image2 = Background.GetComponent<Image>();
                image2.sprite = BackgroundImage2;
            }
            if (Value == 2)
            {
                Image image3 = Background.GetComponent<Image>();
                image3.sprite = BackgroundImage3;
            }
        }
    }
}