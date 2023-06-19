using InventoryList; 
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public int MaxInventory = 10;
    public List<Item> ChestInventory = new List<Item>();

    public TMP_Text ChestItem1;
    public TMP_Text ChestItem2;
    public TMP_Text ChestItem3;
    public TMP_Text ChestItem4;
    public TMP_Text ChestItem5;
    public TMP_Text ChestItem6;
    public TMP_Text ChestItem7;
    public TMP_Text ChestItem8;
    public TMP_Text ChestItem9;
    public TMP_Text ChestItem10;
    public TMP_Text ChestItem11;
    public TMP_Text ChestItem12;
    public TMP_Text ChestItem13;
    public TMP_Text ChestItem14;
    public TMP_Text ChestItem15;

    public GameObject InventoryWarning;

    public TMP_Text backpackText;

    public GameObject BackpackManager;
    private Backpack Inventory;

    public GameObject BackpackItems;
    private Shop BackpackItem;

    public int ItemCounter;
    public TMP_Text CounterText;

    public TMP_Text InventoryText;
    public int InventoryCount;

    public TMP_Text ChestMax;

    private void Start()
    {
        BackpackItem = BackpackItems.GetComponent<Shop>();

        Inventory = BackpackManager.GetComponent<Backpack>();
        backpackText.text = ListToText(Inventory.BackpackInventory);
    }
    public void Organise()
    {
        ChestInventory.Sort();

        ChestItem1.text = ChestInventory[0].ItemName;
        ChestItem2.text = ChestInventory[1].ItemName;
        ChestItem3.text = ChestInventory[2].ItemName;
        ChestItem4.text = ChestInventory[3].ItemName;
        ChestItem5.text = ChestInventory[4].ItemName;
        ChestItem6.text = ChestInventory[5].ItemName;
        ChestItem7.text = ChestInventory[6].ItemName;
        ChestItem8.text = ChestInventory[7].ItemName;
        ChestItem9.text = ChestInventory[8].ItemName;
        ChestItem10.text = ChestInventory[9].ItemName;
        ChestItem11.text = ChestInventory[10].ItemName;
        ChestItem12.text = ChestInventory[11].ItemName;
        ChestItem13.text = ChestInventory[12].ItemName;
        ChestItem14.text = ChestInventory[13].ItemName;
        ChestItem15.text = ChestInventory[14].ItemName;

    }
    private void Update()
    {
        ItemCounter = ChestInventory.Count;
        CounterText.text = ItemCounter.ToString();

        InventoryCount = Inventory.BackpackInventory.Count; 
        InventoryText.text = InventoryCount.ToString();

        if (ChestMax.text == " ")
        {
            MaxInventory = 100000;
        }
    }
    public void Transfer()
    {
        if (ItemCounter >= MaxInventory)
        {
            InventoryWarning.SetActive(true);
        }
        else
        {
            ChestInventory.AddRange(BackpackItem.BackpackItem);
            Inventory.BackpackInventory.Clear();
            BackpackItem.BackpackItem.Clear();
            backpackText.text = " ";

            ChestItem1.text = ChestInventory[0].ItemName;
            ChestItem2.text = ChestInventory[1].ItemName;
            ChestItem3.text = ChestInventory[2].ItemName;
            ChestItem4.text = ChestInventory[3].ItemName;
            ChestItem5.text = ChestInventory[4].ItemName;
            ChestItem6.text = ChestInventory[5].ItemName;
            ChestItem7.text = ChestInventory[6].ItemName;    
            ChestItem8.text = ChestInventory[7].ItemName;
            ChestItem9.text = ChestInventory[8].ItemName;
            ChestItem10.text = ChestInventory[9].ItemName;
            ChestItem11.text = ChestInventory[10].ItemName;
            ChestItem12.text = ChestInventory[11].ItemName;
            ChestItem13.text = ChestInventory[12].ItemName;
            ChestItem14.text = ChestInventory[13].ItemName;
            ChestItem15.text = ChestInventory[14].ItemName;

           
        }
    }
    private string ListToText(List<string> List)
    {
        string result = "";

        foreach (var Member in Inventory.BackpackInventory)
        {
            result += Member.ToString() + "\n";
        }
        return result;
    }

    public void TransferItem1()
    {
        ChestInventory.RemoveAt(0);
        Inventory.BackpackInventory.Add(ChestInventory[0].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[0]);


        ChestItem1.text = " ";
        backpackText.text = ListToText(Inventory.BackpackInventory);
    }
    public void TransferItem2()
    {
        ChestInventory.RemoveAt(1);
        Inventory.BackpackInventory.Add(ChestInventory[1].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[1]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem2.text = " ";
    }
    public void TransferItem3()
    {
        ChestInventory.RemoveAt(2);
        Inventory.BackpackInventory.Add(ChestInventory[2].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[2]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem3.text = " ";
    }
    public void TransferItem4()
    {
        ChestInventory.RemoveAt(3);
        Inventory.BackpackInventory.Add(ChestInventory[3].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[3]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem4.text = " ";
    }
    public void TransferItem5()
    {
        ChestInventory.RemoveAt(4);
        Inventory.BackpackInventory.Add(ChestInventory[4].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[4]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem5.text = " ";
    }
    public void TransferItem6()
    {
        ChestInventory.RemoveAt(5);
        Inventory.BackpackInventory.Add(ChestInventory[5].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[5]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem6.text = " ";
    }
    public void TransferItem7()
    {
        ChestInventory.RemoveAt(6);
        Inventory.BackpackInventory.Add(ChestInventory[6].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[6]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem7.text = " ";
    }
    public void TransferItem8()
    {
        ChestInventory.RemoveAt(7);
        Inventory.BackpackInventory.Add(ChestInventory[7].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[7]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem8.text = " ";
    }
    public void TransferItem9()
    {
        ChestInventory.RemoveAt(8);
        Inventory.BackpackInventory.Add(ChestInventory[8].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[8]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem9.text = " ";
    }
    public void TransferItem10()
    {
        ChestInventory.RemoveAt(9);
        Inventory.BackpackInventory.Add(ChestInventory[9].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[9]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem10.text = " ";
    }
    public void TransferItem11()
    {
        ChestInventory.RemoveAt(10);
        Inventory.BackpackInventory.Add(ChestInventory[10].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[10]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem11.text = " ";
    }
    public void TransferItem12()
    {
        ChestInventory.RemoveAt(11);
        Inventory.BackpackInventory.Add(ChestInventory[11].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[11]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem12.text = " ";
    }
    public void TransferItem13()
    {
        ChestInventory.RemoveAt(12);
        Inventory.BackpackInventory.Add(ChestInventory[12].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[12]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem13.text = " ";
    }
    public void TransferItem14()
    {
        ChestInventory.RemoveAt(13);
        Inventory.BackpackInventory.Add(ChestInventory[13].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[13]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem14.text = " ";
    }
    public void TransferItem15()
    {
        ChestInventory.RemoveAt(14);
        Inventory.BackpackInventory.Add(ChestInventory[14].ItemName);
        BackpackItem.BackpackItem.Add(ChestInventory[14]);

        backpackText.text = ListToText(Inventory.BackpackInventory);
        ChestItem15.text = " ";
    }
}
