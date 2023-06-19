using System.Collections.Generic;
using UnityEngine;

namespace InventoryList
{
    public class ItemList : MonoBehaviour
    {
        [SerializeField] Item FirePotion;
        [SerializeField] Item WaterPotion;
        [SerializeField] Item StormPotion;
        [SerializeField] Item Poison;
        [SerializeField] Item LovePotion;
        [SerializeField] Item EarthPotion;
        [SerializeField] Item AirPotion;
        [SerializeField] Item DeathPotion;

        [SerializeField] Item Dagger;
        [SerializeField] Item ShortSword;
        [SerializeField] Item Crossbow;
        [SerializeField] Item Bow;
        [SerializeField] Item Spear;
        [SerializeField] Item LongSword;
        [SerializeField] Item Pistol;

        [SerializeField] Item FireflyJar;
        [SerializeField] Item WilloWispJar;
        [SerializeField] Item JamJar;
        [SerializeField] Item PickleJar;
        [SerializeField] Item UnknownJar;
        [SerializeField] Item HeartJar;

        public List<Item> ItemInventory = new();


        private void Start()
        {
            Potions();
            Weapons();
            Jars();  
            AddInventoryItems();
        }

        public void Potions()
        {
            FirePotion = new Item("Fire Potion", "Deals +5 damage", 15, Item.ItemType.Potion);
            WaterPotion = new Item("Water Potion", "Deals -5 damage", 10, Item.ItemType.Potion);
            StormPotion = new Item("Storm Potion", "Deals +15 damage", 35, Item.ItemType.Potion);
            Poison = new Item("Poison", "Deals +3 damage", 5, Item.ItemType.Potion);
            LovePotion = new Item("Love Potion", "Enemies that are hit with this potion aids your party for 7 seconds", 25, Item.ItemType.Potion);
            EarthPotion = new Item("Earth Potion", "Causes an Earthquake for 5 seconds", 20, Item.ItemType.Potion);
            AirPotion = new Item("Air Potion", "Consumer can doublejump for 20 seconds", 30, Item.ItemType.Potion);
            DeathPotion = new Item("Death Potion", "Any enemy within the radius of the potion intstantly dies", 55, Item.ItemType.Potion);
        }
        public void Weapons()
        {
            Dagger = new Item("Amythest Dagger", "Deals +1 damage, at least it's pretty.", 5, Item.ItemType.Weapon);
            ShortSword = new Item("Colonel Shortcake's Sword", "Deals +5 damage, made especially for the Colonel to fit his short height.", 10, Item.ItemType.Weapon);
            Crossbow = new Item("Sturdy Crossbow", "Deals +5 damage, made from oak wood.", 15, Item.ItemType.Weapon);
            Bow = new Item("Artemis' Bow", "Deals +10 damage, a powerful bow fit for a goddess.", 25, Item.ItemType.Weapon);
            Spear = new Item("Obsidian Spear", "Deals +7 damage, it is VERY sharp.", 15, Item.ItemType.Weapon);
            LongSword = new Item("FireDemon's Sword", "Deals +15 damage, one look can burn your enemies.", 40, Item.ItemType.Weapon);
            Pistol = new Item("Blood's Pistol", "Deals +15 damage, He never missed and he only had one eye.", 40, Item.ItemType.Weapon);

        }
        public void Jars()
        {
            FireflyJar = new Item("Firefly Jar", "Lights your way for 10 seconds", 15, Item.ItemType.Jar);
            WilloWispJar = new Item("WiLl o Wisp Jar", "Guides you to treasure", 20, Item.ItemType.Jar);
            JamJar = new Item("Jam Jar", "Doubles your speed for 8 seconds", 10, Item.ItemType.Jar);
            PickleJar = new Item("Pickle Jar", "Increases your damage dealt for 10 seconds", 15, Item.ItemType.Jar);
            UnknownJar = new Item("Unknown Jar", "You take less damage for 15 seconds", 20, Item.ItemType.Jar);
            HeartJar = new Item("Heart Jar", "Increases your health by 3", 10, Item.ItemType.Jar);
        }
        public void AddInventoryItems()
        {
            ItemInventory.Add(FirePotion); //0
            ItemInventory.Add(WaterPotion); //1
            ItemInventory.Add(StormPotion); //2
            ItemInventory.Add(Poison);//3
            ItemInventory.Add(LovePotion); //4
            ItemInventory.Add(EarthPotion); //5
            ItemInventory.Add(AirPotion); //6
            ItemInventory.Add(DeathPotion);//7

            ItemInventory.Add(Dagger); //8
            ItemInventory.Add(ShortSword);//9
            ItemInventory.Add(Crossbow);//10
            ItemInventory.Add(Bow);//11
            ItemInventory.Add(Spear);//12
            ItemInventory.Add(LongSword);//13
            ItemInventory.Add(Pistol);//14

            ItemInventory.Add(FireflyJar);//15
            ItemInventory.Add(WilloWispJar);//16
            ItemInventory.Add(JamJar);//17
            ItemInventory.Add(PickleJar);//18
            ItemInventory.Add(UnknownJar);//19
            ItemInventory.Add(HeartJar);//20

        }
    }


    //plain class to create instances of the object
    [System.Serializable]
    public class Item
    {
        public enum ItemType { Weapon, Jar, Potion};
        public string ItemName;
        public string ItemDescription;
        public int ItemPrice;
        public ItemType Type;

        public Item()
        {

        }

        public Item(string itemName, string itemDescription, int itemPrice, ItemType type)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            ItemDescription = itemDescription;
            Type = type;
        }

    }
}
