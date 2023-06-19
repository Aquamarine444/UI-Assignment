using System.Collections.Generic;
using UnityEngine;
using InventoryList;
using TMPro;

public class Shop : MonoBehaviour
{
    public TMP_Text Timer;
    public float TimeRemaining = 15f; 
    public bool TimeFinished = false;

    public List<Item> ShopInventory = new();

    public List<Item> BackpackItem = new();

    private Backpack Inventory;
    public GameObject BackpackManager;
    private int InventoryCounter;
    public TMP_Text Counter;
    private int MaxInventory = 5;

    public TMP_Text BackpackMax;
    public TMP_Text BackpackInventory;

    public TMP_Text ChestMax;
    private int MaxChestInventory;
    public GameObject ChestUpgrade;

    private ItemList Items;
    public GameObject ItemManager;

    public TMP_Text MoneyText;
    public int PlayerMoney = 100;
    public int ShopPrice;

    //ShopTexts
    public TMP_Text ShopItem1;
    public TMP_Text ShopItem2;
    public TMP_Text ShopItem3;
    public TMP_Text ShopItem4;
    public TMP_Text ShopItem5;
    public TMP_Text ShopItem6;
    public TMP_Text ShopItem7;
    public TMP_Text ShopItem8;
    public TMP_Text ShopItem9;
    public TMP_Text ShopItem10;
     
    //Shop GameObjects
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5;
    public GameObject Item6;
    public GameObject Item7;
    public GameObject Item8;
    public GameObject Item9;
    public GameObject Item10;

    //Backpack Texts
    public TMP_Text SlotOne;
    public TMP_Text SlotTwo;
    public TMP_Text SlotThree;
    public TMP_Text SlotFour;
    public TMP_Text SlotFive;

    public TMP_Text SlotSix;
    public TMP_Text SlotSeven;
    public TMP_Text SlotEight;
    public TMP_Text SlotNine;
    public TMP_Text SlotTen;


    //Backpack GameObject
    public GameObject InventoryItem1;
    public GameObject InventoryItem2;
    public GameObject InventoryItem3;
    public GameObject InventoryItem4;
    public GameObject InventoryItem5;

    public GameObject InventoryItem6;
    public GameObject InventoryItem7;
    public GameObject InventoryItem8;
    public GameObject InventoryItem9;
    public GameObject InventoryItem10;

    public GameObject BackpackUpgrade;

    private float ExtraTimer1 = 15f;
    private bool ExtraFinished1 = false;

    private float ExtraTimer2 = 30f;
    private bool ExtraFinished2 = false;

    private float ExtraTimer3 = 45f;
    private bool ExtraFinished3 = false;

    public TMP_Text TooltipText;

    public GameObject MoneyError;
    public GameObject InventoryWarning;

    public GameObject ChestItem11;
    public GameObject ChestItem12;
    public GameObject ChestItem13;
    public GameObject ChestItem14;
    public GameObject ChestItem15;
    void Start()
    {
        TimeFinished = true;
        ExtraFinished1 = true;
        ExtraFinished2 = true;
        ExtraFinished3 = true;
        Items = ItemManager.GetComponent<ItemList>();
        ShopInventory.AddRange(Items.ItemInventory);
        Shuffle();

        ShopItem1.text = ShopInventory[0].ItemName;
        ShopItem2.text = ShopInventory[1].ItemName;
        ShopItem3.text = ShopInventory[2].ItemName;
        ShopItem4.text = ShopInventory[3].ItemName;
        ShopItem5.text = ShopInventory[4].ItemName;
        ShopItem6.text = ShopInventory[5].ItemName;
        ShopItem7.text = ShopInventory[6].ItemName;
        ShopItem8.text = ShopInventory[7].ItemName;
        ShopItem9.text = ShopInventory[8].ItemName;
        ShopItem10.text = ShopInventory[9].ItemName;

        Inventory = BackpackManager.GetComponent<Backpack>();

        MoneyText.text = PlayerMoney.ToString();

        BackpackItem.Add(Items.ItemInventory[0]);
        BackpackItem.Add(Items.ItemInventory[8]);
        BackpackItem.Add(Items.ItemInventory[15]);
    }

    void Update()
    {
        InventoryCounter = Inventory.BackpackInventory.Count;
        Counter.text = InventoryCounter.ToString();
            if (TimeFinished == true)
            {
                if (TimeRemaining > 0)
                {
                    TimeRemaining -= Time.deltaTime; //decreases the timeramount
                    Timer.text = (TimeRemaining).ToString("0");//displays the timer in text
                }
                else 
                {
                    //if the timer hits 0 then the following code is run
                    TimeRemaining = 0;
                    TimeFinished = false;
                Shuffle();
                ShopItem1.text = ShopInventory[0].ItemName;
                ShopItem2.text = ShopInventory[1].ItemName;
                ShopItem3.text = ShopInventory[2].ItemName;
                ShopItem4.text = ShopInventory[3].ItemName;
                ShopItem5.text = ShopInventory[4].ItemName;
                ShopItem6.text = ShopInventory[5].ItemName;
                ShopItem7.text = ShopInventory[6].ItemName;

                if (TimeRemaining == 0)
                {
                    TimeFinished = true;
                    TimeRemaining = 15f;
                }
                }
            }

        if (ExtraFinished1 == true)
        {
            if (ExtraTimer1 > 0)
            {
                ExtraTimer1 -= Time.deltaTime;
            }
            else
            {
                ExtraTimer1 = 0;
                ExtraFinished1 = false;
                Item8.SetActive(true);
            }
        }
        if (ExtraFinished2 == true)
        {
            if (ExtraTimer2 > 0)
            {
                ExtraTimer2 -= Time.deltaTime;
            }
            else
            {
                ExtraTimer2 = 0;
                ExtraFinished2 = false;
                Item9.SetActive(true);
            }
        }
        if (ExtraFinished3 == true)
        {
            if (ExtraTimer3 > 0)
            {
                ExtraTimer3 -= Time.deltaTime;
            }
            else
            {
                ExtraTimer3 = 0;
                ExtraFinished3 = false;

                Item10.SetActive(true);
                BackpackUpgrade.SetActive(true);
                ChestUpgrade.SetActive(true);
            }
        }

    }

    public void Shuffle()
    {
        for (int i = 0; i < ShopInventory.Count; i++)
        {
            Item temp = ShopInventory[i];
            int randomIndex = Random.Range(i, ShopInventory.Count);
            ShopInventory[i] = ShopInventory[randomIndex];
            ShopInventory[randomIndex] = temp;
        }

        Item1.SetActive(true);
        Item2.SetActive(true);
        Item3.SetActive(true);
        Item4.SetActive(true);
        Item5.SetActive(true);
        Item6.SetActive(true);
        Item7.SetActive(true);
    }

    public void ShopItemOne()
    {
        if (PlayerMoney <= 0)
        {
            MoneyError.SetActive(true);
        }
        else if (InventoryCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else 
        {
            ShopPrice = ShopInventory[0].ItemPrice;
            PlayerMoney = PlayerMoney - ShopPrice;
            MoneyText.text = PlayerMoney.ToString();
            Item1.SetActive(false);
            Inventory.BackpackInventory.Add(ShopInventory[0].ItemName);
            BackpackItem.Add(ShopInventory[0]);

            SlotOne.text = Inventory.BackpackInventory[0];
            SlotTwo.text = Inventory.BackpackInventory[1];
            SlotThree.text = Inventory.BackpackInventory[2];
            SlotFour.text = Inventory.BackpackInventory[3];
            SlotFive.text = Inventory.BackpackInventory[4];

            SlotSix.text = Inventory.BackpackInventory[5];
            SlotSeven.text = Inventory.BackpackInventory[6];
            SlotEight.text = Inventory.BackpackInventory[7];
            SlotNine.text = Inventory.BackpackInventory[8];
            SlotTen.text = Inventory.BackpackInventory[9];
        }
    }
    public void ShopItemTwo()
    {
        if (PlayerMoney <= 0)
        {
            MoneyError.SetActive(true);
        }
        else if (InventoryCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else
        {
            ShopPrice = ShopInventory[1].ItemPrice;
            PlayerMoney = PlayerMoney - ShopPrice;
            MoneyText.text = PlayerMoney.ToString();
            Item2.SetActive(false);
            Inventory.BackpackInventory.Add(ShopInventory[1].ItemName);
            BackpackItem.Add(ShopInventory[1]);

            SlotOne.text = Inventory.BackpackInventory[0];
            SlotTwo.text = Inventory.BackpackInventory[1];
            SlotThree.text = Inventory.BackpackInventory[2];
            SlotFour.text = Inventory.BackpackInventory[3];
            SlotFive.text = Inventory.BackpackInventory[4];

            SlotSix.text = Inventory.BackpackInventory[5];
            SlotSeven.text = Inventory.BackpackInventory[6];
            SlotEight.text = Inventory.BackpackInventory[7];
            SlotNine.text = Inventory.BackpackInventory[8];
            SlotTen.text = Inventory.BackpackInventory[9];
        }
    }
    public void ShopItemThree()
    {
        if (PlayerMoney <= 0)
        {
            MoneyError.SetActive(true);
        }
        else if (InventoryCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else
        {
            ShopPrice = ShopInventory[2].ItemPrice;
            PlayerMoney = PlayerMoney - ShopPrice;
            MoneyText.text = PlayerMoney.ToString();
            Item3.SetActive(false);
            Inventory.BackpackInventory.Add(ShopInventory[2].ItemName);
            BackpackItem.Add(ShopInventory[2]);

            SlotOne.text = Inventory.BackpackInventory[0];
            SlotTwo.text = Inventory.BackpackInventory[1];
            SlotThree.text = Inventory.BackpackInventory[2];
            SlotFour.text = Inventory.BackpackInventory[3];
            SlotFive.text = Inventory.BackpackInventory[4];

            SlotSix.text = Inventory.BackpackInventory[5];
            SlotSeven.text = Inventory.BackpackInventory[6];
            SlotEight.text = Inventory.BackpackInventory[7];
            SlotNine.text = Inventory.BackpackInventory[8];
            SlotTen.text = Inventory.BackpackInventory[9];
        }
    }
    public void ShopItemFour()
    {
        if (PlayerMoney <= 0)
        {
            MoneyError.SetActive(true);
        }
        else if (InventoryCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else
        {
            ShopPrice = ShopInventory[3].ItemPrice;
            PlayerMoney = PlayerMoney - ShopPrice;
            MoneyText.text = PlayerMoney.ToString();
            Item4.SetActive(false);
            Inventory.BackpackInventory.Add(ShopInventory[3].ItemName);
            BackpackItem.Add(ShopInventory[3]);

            SlotOne.text = Inventory.BackpackInventory[0];
            SlotTwo.text = Inventory.BackpackInventory[1];
            SlotThree.text = Inventory.BackpackInventory[2];
            SlotFour.text = Inventory.BackpackInventory[3];
            SlotFive.text = Inventory.BackpackInventory[4];

            SlotSix.text = Inventory.BackpackInventory[5];
            SlotSeven.text = Inventory.BackpackInventory[6];
            SlotEight.text = Inventory.BackpackInventory[7];
            SlotNine.text = Inventory.BackpackInventory[8];
            SlotTen.text = Inventory.BackpackInventory[9];
        }
    }
    public void ShopItemFive()
    {
        if (PlayerMoney <= 0)
        {
            MoneyError.SetActive(true);
        }
        else if (InventoryCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else
        {
            ShopPrice = ShopInventory[4].ItemPrice;
            PlayerMoney = PlayerMoney - ShopPrice;
            MoneyText.text = PlayerMoney.ToString();
            Item5.SetActive(false);
            Inventory.BackpackInventory.Add(ShopInventory[4].ItemName);
            BackpackItem.Add(ShopInventory[4]);

            SlotOne.text = Inventory.BackpackInventory[0];
            SlotTwo.text = Inventory.BackpackInventory[1];
            SlotThree.text = Inventory.BackpackInventory[2];
            SlotFour.text = Inventory.BackpackInventory[3];
            SlotFive.text = Inventory.BackpackInventory[4];

            SlotSix.text = Inventory.BackpackInventory[5];
            SlotSeven.text = Inventory.BackpackInventory[6];
            SlotEight.text = Inventory.BackpackInventory[7];
            SlotNine.text = Inventory.BackpackInventory[8];
            SlotTen.text = Inventory.BackpackInventory[9];
        }
    }
    public void ShopItemSix()
    {
        if (PlayerMoney <= 0)
        {
            MoneyError.SetActive(true);
        }
        else if (InventoryCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else
        {
            ShopPrice = ShopInventory[5].ItemPrice;
            PlayerMoney = PlayerMoney - ShopPrice;
            MoneyText.text = PlayerMoney.ToString();
            Item6.SetActive(false);
            Inventory.BackpackInventory.Add(ShopInventory[5].ItemName);
            BackpackItem.Add(ShopInventory[5]);

            SlotOne.text = Inventory.BackpackInventory[0];
            SlotTwo.text = Inventory.BackpackInventory[1];
            SlotThree.text = Inventory.BackpackInventory[2];
            SlotFour.text = Inventory.BackpackInventory[3];
            SlotFive.text = Inventory.BackpackInventory[4];

            SlotSix.text = Inventory.BackpackInventory[5];
            SlotSeven.text = Inventory.BackpackInventory[6];
            SlotEight.text = Inventory.BackpackInventory[7];
            SlotNine.text = Inventory.BackpackInventory[8];
            SlotTen.text = Inventory.BackpackInventory[9];
        }
    }
    public void ShopItemSeven()
    {
        if (PlayerMoney <= 0)
        {
            MoneyError.SetActive(true);
        }
        else if (InventoryCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else
        {
            ShopPrice = ShopInventory[6].ItemPrice;
            PlayerMoney = PlayerMoney - ShopPrice;
            MoneyText.text = PlayerMoney.ToString();
            Item7.SetActive(false);
            Inventory.BackpackInventory.Add(ShopInventory[6].ItemName);
            BackpackItem.Add(ShopInventory[6]);

            SlotOne.text = Inventory.BackpackInventory[0];
            SlotTwo.text = Inventory.BackpackInventory[1];
            SlotThree.text = Inventory.BackpackInventory[2];
            SlotFour.text = Inventory.BackpackInventory[3];
            SlotFive.text = Inventory.BackpackInventory[4];

            SlotSix.text = Inventory.BackpackInventory[5];
            SlotSeven.text = Inventory.BackpackInventory[6];
            SlotEight.text = Inventory.BackpackInventory[7];
            SlotNine.text = Inventory.BackpackInventory[8];
            SlotTen.text = Inventory.BackpackInventory[9];
        }
    }
    public void ShopItemEight()
    {
        if (PlayerMoney <= 0)
        {
            MoneyError.SetActive(true);
        }
        else if (InventoryCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else
        {
            ShopPrice = ShopInventory[7].ItemPrice;
            PlayerMoney = PlayerMoney - ShopPrice;
            MoneyText.text = PlayerMoney.ToString();
            Item8.SetActive(false);
            Inventory.BackpackInventory.Add(ShopInventory[7].ItemName);
            BackpackItem.Add(ShopInventory[7]);

            SlotOne.text = Inventory.BackpackInventory[0];
            SlotTwo.text = Inventory.BackpackInventory[1];
            SlotThree.text = Inventory.BackpackInventory[2];
            SlotFour.text = Inventory.BackpackInventory[3];
            SlotFive.text = Inventory.BackpackInventory[4];

            SlotSix.text = Inventory.BackpackInventory[5];
            SlotSeven.text = Inventory.BackpackInventory[6];
            SlotEight.text = Inventory.BackpackInventory[7];
            SlotNine.text = Inventory.BackpackInventory[8];
            SlotTen.text = Inventory.BackpackInventory[9];
        }
    }
    public void ShopItemNine()
    {
        if (PlayerMoney <= 0)
        {
            MoneyError.SetActive(true);
        }
        else if (InventoryCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else
        {
            ShopPrice = ShopInventory[8].ItemPrice;
            PlayerMoney = PlayerMoney - ShopPrice;
            MoneyText.text = PlayerMoney.ToString();
            Item9.SetActive(false);
            Inventory.BackpackInventory.Add(ShopInventory[8].ItemName);
            BackpackItem.Add(ShopInventory[8]);

            SlotOne.text = Inventory.BackpackInventory[0];
            SlotTwo.text = Inventory.BackpackInventory[1];
            SlotThree.text = Inventory.BackpackInventory[2];
            SlotFour.text = Inventory.BackpackInventory[3];
            SlotFive.text = Inventory.BackpackInventory[4];

            SlotSix.text = Inventory.BackpackInventory[5];
            SlotSeven.text = Inventory.BackpackInventory[6];
            SlotEight.text = Inventory.BackpackInventory[7];
            SlotNine.text = Inventory.BackpackInventory[8];
            SlotTen.text = Inventory.BackpackInventory[9];
        }
    }
    public void ShopItemTen()
    {
        if (PlayerMoney <= 0)
        {
            MoneyError.SetActive(true);
        }
        else if (InventoryCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else
        {
            ShopPrice = ShopInventory[9].ItemPrice;
            PlayerMoney = PlayerMoney - ShopPrice;
            MoneyText.text = PlayerMoney.ToString();
            Item10.SetActive(false);
            Inventory.BackpackInventory.Add(ShopInventory[9].ItemName);
            BackpackItem.Add(ShopInventory[9]);

            SlotOne.text = Inventory.BackpackInventory[0];
            SlotTwo.text = Inventory.BackpackInventory[1];
            SlotThree.text = Inventory.BackpackInventory[2];
            SlotFour.text = Inventory.BackpackInventory[3];
            SlotFive.text = Inventory.BackpackInventory[4];

            SlotSix.text = Inventory.BackpackInventory[5];
            SlotSeven.text = Inventory.BackpackInventory[6];
            SlotEight.text = Inventory.BackpackInventory[7];
            SlotNine.text = Inventory.BackpackInventory[8];
            SlotTen.text = Inventory.BackpackInventory[9];
        }
    }

    public void SellItemOne()
    {
        ShopPrice = BackpackItem[0].ItemPrice;
        PlayerMoney = PlayerMoney + ShopPrice;
        MoneyText.text = PlayerMoney.ToString();
        Inventory.BackpackInventory.RemoveAt(0);
        BackpackItem.RemoveAt(0);

        SlotOne.text = " ";
    }
    public void SellItemTwo()
    {
        ShopPrice = BackpackItem[1].ItemPrice;
        PlayerMoney = PlayerMoney + ShopPrice;
        MoneyText.text = PlayerMoney.ToString();
        Inventory.BackpackInventory.RemoveAt(1);
        BackpackItem.RemoveAt(1);

        SlotTwo.text = " ";
    }
    public void SellItemThree()
    {
        ShopPrice = BackpackItem[2].ItemPrice;
        PlayerMoney = PlayerMoney + ShopPrice;
        MoneyText.text = PlayerMoney.ToString();
        Inventory.BackpackInventory.RemoveAt(2);
        BackpackItem.RemoveAt(2);

        SlotThree.text = " ";
    }
    public void SellItemFour()
    {
        ShopPrice = BackpackItem[3].ItemPrice;
        PlayerMoney = PlayerMoney + ShopPrice;
        MoneyText.text = PlayerMoney.ToString();
        Inventory.BackpackInventory.RemoveAt(3);
        BackpackItem.RemoveAt(3);

        SlotFour.text = " ";
    }
    public void SellItemFive()
    {
        ShopPrice = BackpackItem[4].ItemPrice;
        PlayerMoney = PlayerMoney + ShopPrice;
        MoneyText.text = PlayerMoney.ToString();
        Inventory.BackpackInventory.RemoveAt(4);
        BackpackItem.RemoveAt(4);

        SlotFive.text = " ";
    }
    public void SellItemSix()
    {
        ShopPrice = BackpackItem[5].ItemPrice;
        PlayerMoney = PlayerMoney + ShopPrice;
        MoneyText.text = PlayerMoney.ToString();
        Inventory.BackpackInventory.RemoveAt(5);
        BackpackItem.RemoveAt(5);

        SlotSix.text = " ";
    }
    public void SellItemSeven()
    {
        ShopPrice = BackpackItem[6].ItemPrice;
        PlayerMoney = PlayerMoney + ShopPrice;
        MoneyText.text = PlayerMoney.ToString();
        Inventory.BackpackInventory.RemoveAt(6);
        BackpackItem.RemoveAt(6);

        SlotSeven.text = " ";
    }
    public void SellItemEight()
    {
        ShopPrice = BackpackItem[7].ItemPrice;
        PlayerMoney = PlayerMoney + ShopPrice;
        MoneyText.text = PlayerMoney.ToString();
        Inventory.BackpackInventory.RemoveAt(7);
        BackpackItem.RemoveAt(7);

        SlotEight.text = " ";
    }
    public void SellItemNine()
    {
        ShopPrice = BackpackItem[8].ItemPrice;
        PlayerMoney = PlayerMoney + ShopPrice;
        MoneyText.text = PlayerMoney.ToString();
        Inventory.BackpackInventory.RemoveAt(8);
        BackpackItem.RemoveAt(8);

        SlotNine.text = " ";
    }
    public void SellItemTen()
    {
        ShopPrice = BackpackItem[9].ItemPrice;
        PlayerMoney = PlayerMoney + ShopPrice;
        MoneyText.text = PlayerMoney.ToString();
        Inventory.BackpackInventory.RemoveAt(9);
        BackpackItem.RemoveAt(9);

        SlotTen.text = " ";
    }

    public void DropdownInpout(int Value, Item item)
    {
        if (Value == 0)
        {
      
        }
        if (Value == 1)
        {

        }
        if (Value == 2)
        {

        }
        if (Value == 3)
        {

        }
    }

    public void UpgradeBackpack()
    {
        MaxInventory = 10;
        BackpackMax.text = "/" + MaxInventory.ToString();
        BackpackInventory.text = "/" + MaxInventory.ToString();
        BackpackUpgrade.SetActive(false);

        InventoryItem6.SetActive(true);
        InventoryItem7.SetActive(true);
        InventoryItem8.SetActive(true);
        InventoryItem9.SetActive(true);
        InventoryItem10.SetActive(true);
    }

    public void UpgradeChest()
    {
        MaxChestInventory = 10000;
        ChestMax.text = " ";
        ChestUpgrade.SetActive(false);

        ChestItem11.SetActive(true);
        ChestItem12.SetActive(true);
        ChestItem13.SetActive(true);
        ChestItem14.SetActive(true);
        ChestItem15.SetActive(true);
    }

    public void DescriptionDisplay1()
    {
        TooltipText.text = ShopInventory[0].ItemDescription + ". Price: " + ShopInventory[0].ItemPrice.ToString();
    }
    public void DescriptionDisplay2()
    {
        TooltipText.text = ShopInventory[1].ItemDescription + ". Price: " + ShopInventory[1].ItemPrice.ToString();
    }
    public void DescriptionDisplay3()
    {
        TooltipText.text = ShopInventory[2].ItemDescription + ". Price: " + ShopInventory[2].ItemPrice.ToString();
    }
    public void DescriptionDisplay4()
    {
        TooltipText.text = ShopInventory[3].ItemDescription + ". Price: " + ShopInventory[3].ItemPrice.ToString();
    }
    public void DescriptionDisplay5()
    {
        TooltipText.text = ShopInventory[4].ItemDescription + ". Price: " + ShopInventory[4].ItemPrice.ToString();
    }
    public void DescriptionDisplay6()
    {
        TooltipText.text = ShopInventory[5].ItemDescription + ". Price: " + ShopInventory[5].ItemPrice.ToString();
    }
    public void DescriptionDisplay7()
    {
        TooltipText.text = ShopInventory[6].ItemDescription + ". Price: " + ShopInventory[6].ItemPrice.ToString();
    }
    public void DescriptionDisplay8()
    {
        TooltipText.text = ShopInventory[7].ItemDescription + ". Price: " + ShopInventory[7].ItemPrice.ToString();
    }
    public void DescriptionDisplay9()
    {
        TooltipText.text = ShopInventory[8].ItemDescription + ". Price: " + ShopInventory[8].ItemPrice.ToString();
    }
    public void DescriptionDisplay10()
    {
        TooltipText.text = ShopInventory[9].ItemDescription + ". Price: " + ShopInventory[9].ItemPrice.ToString();
    }

}   

